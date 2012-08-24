#include <noiseFunction.fx>
#include <helper.fx>

sampler baseSampler : register(s0);
float2 renderTargetSize;
bool flora1;
float2 flora1Range;
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

	// Flora layer 1
	if (flora1 && total >= flora1Range.x && total <= flora1Range.y)
	{
		float mean = (flora1Range.x + flora1Range.y) / 2;
		float max = absolute(flora1Range.x - mean);
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
