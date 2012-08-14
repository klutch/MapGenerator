sampler baseSampler : register(s0) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
};

float2 randomTextureSize;
float2 renderTargetSize;
float randomTextureScale;

float4 perlin(float2 texCoords)
{
	float2 pixel = float2(8, 8) / renderTargetSize;
	float4 noise = float4(0, 0, 0, 1);
	noise += tex2D(baseSampler, texCoords + float2(-pixel.x, -pixel.y));
	noise += tex2D(baseSampler, texCoords + float2(pixel.x, -pixel.y));
	noise += tex2D(baseSampler, texCoords + float2(pixel.x, pixel.y));
	noise += tex2D(baseSampler, texCoords + float2(-pixel.x, pixel.y));
	noise.rgb /= 16;

	noise += tex2D(baseSampler, texCoords + float2(-pixel.x, 0));
	noise += tex2D(baseSampler, texCoords + float2(pixel.x, 0));
	noise += tex2D(baseSampler, texCoords + float2(0, -pixel.x));
	noise += tex2D(baseSampler, texCoords + float2(0, pixel.x));
	noise.rgb /= 8;

	noise.rgb += tex2D(baseSampler, texCoords).rgb / 4;

	return noise;
}

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	return perlin(texCoords * (renderTargetSize / randomTextureSize) / randomTextureScale);
}

technique Main
{
    pass Base
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
