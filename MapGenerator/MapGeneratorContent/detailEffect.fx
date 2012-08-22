#include <noiseFunction.fx>

sampler baseSampler : register(s0);
sampler worleySampler : register(s1);
float4x4 matrixTransform;
float2 position;
float scale;
float2 renderTargetSize;
float2 noiseTextureSize;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSWorleyNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float2 p = 
		(position / renderTargetSize) - 
		texCoords * (renderTargetSize / noiseTextureSize) / scale;

	float4 base = tex2D(baseSampler, texCoords);
	float total = worley(worleySampler, p / 4);
	total *= worley(worleySampler, p / 2);
	total *= worley(worleySampler, p);
	total *= worley(worleySampler, p * 2);
	total *= worley(worleySampler, p * 4);
	total *= worley(worleySampler, p * 8);
	return float4(total, total, total, 1);
	//return base;
}

technique Main
{
    pass Worley
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSWorleyNoise();
    }
}