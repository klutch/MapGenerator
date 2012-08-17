#include <noiseFunction.fx>

sampler baseSampler : register(s0);
float2 renderTargetSize;
bool flora1;
float2 flora1Range;
float4x4 matrixTransform;

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

	// Flora layer 1
	if (flora1)
	{
		float range1Mean = (flora1Range.x + flora1Range.y) / 2;
		if (total >= flora1Range.x && total <= flora1Range.y)
		{
			float max = abs(flora1Range.x - range1Mean);
			float alpha = 1 - (abs(total - range1Mean) / max);
			result.ga = float2(total, alpha);
		}
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
