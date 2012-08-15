#include <noiseFunction.fx>

sampler baseSampler : register(s0);
float2 renderTargetSize;
float4x4 matrixTransform;

float2 range1 = float2(0, 0.3);

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSBaseFlora(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float4 result = 0;

	float total = (base.r + base.g + base.b) / 3;
	float mean = (range1.x + range1.y) / 2;
	
	if (total >= range1.x && total <= range1.y)
	{
		float max = abs(range1.x - mean);
		float alpha = 1 - (abs(total - mean) / max);
		result.ga = float2(total, alpha);
	}

	return result;
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseFlora();
    }
}
