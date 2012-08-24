#include <noiseFunction.fx>
#include <helper.fx>

sampler baseSampler : register(s0);
float2 renderTargetSize;
float2 floraRange;
float4x4 matrixTransform;
float4 color;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSFlora(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float4 result = 0;
	float total = base.rgb * base.a;

	// Flora layer
	if (total >= floraRange.x && total <= floraRange.y)
	{
		float mean = (floraRange.x + floraRange.y) / 2;
		float max = absolute(floraRange.x - mean);
		float alpha = max >= 0.00001 ? 1 - (absolute(total - mean) / max) : 0;

		result.rgb = total * color;
		result.a = alpha;
	}

	return result;
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSFlora();
    }
}
