#include <helper.fx>

sampler baseSampler : register(s0);
float4x4 matrixTransform;
bool layer1;
float2 layer1Range;

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
	if (layer1 && total >= layer1Range.x && total <= layer1Range.y)
	{
		float mean = (layer1Range.x + layer1Range.y) / 2;
		float max = absolute(layer1Range.x - mean);
		float alpha = max >= 0.00001 ? 1 - (absolute(total - mean) / max) : 0;

		result.ga = float2(total, alpha);
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