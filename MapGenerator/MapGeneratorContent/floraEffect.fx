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

// XNA uses the March 2009 directx sdk, which has a buggy hlsl compiler that tries to
// use 'preshaders'. Disabling preshaders allows the shader to compile, but there's no way
// to do that from Visual Studio (that I'm aware of). Things like saturate, clamp, abs, etc
// can't be used on external parameters in Release mode with preshaders enabled, so I have
// to write my own absolute function :(
float absolute(float value)
{
	return sqrt(value * value);
}

// Pixel shader
float4 PSBaseFlora(float2 texCoords:TEXCOORD0) : COLOR0
{
	float4 base = tex2D(baseSampler, texCoords);
	float4 result = 0;
	float total = (base.r + base.g + base.b) / 3;

	// Flora layer 1
	if (flora1 && total >= flora1Range.x && total <= flora1Range.y)
	{
		float mean = (flora1Range.x + flora1Range.y) / 2;
		float max = absolute(flora1Range.x - mean);
		float alpha = max >= 0.00001 ? 1 - (absolute(total - mean) / max) : 0;

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
