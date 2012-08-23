#include <helper.fx>

sampler baseSampler : register(s0);
float4x4 matrixTransform;
float2 layerRange;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSWorleyNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float4 result = 0;
	float total = (base.r + base.g + base.b) / 3;

	// Details layer 1
	if (total >= layerRange.x && total <= layerRange.y)
	{
		float mean = (layerRange.x + layerRange.y) / 2;
		float max = absolute(layerRange.x - mean);
		float alpha = max >= 0.00001 ? 1 - (absolute(total - mean) / max) : 0;

		result.a = alpha;
	}

	return result;
}

technique Main
{
    pass Worley
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSWorleyNoise();
    }
}