sampler baseSampler : register(s0) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
};

float2 randomTextureSize;
float2 renderTargetSize;
float randomTextureScale;

float noiseFrequency;
float noiseGain;
float noiseLacunarity;
int noiseOctaves;

float noise(float2 position)
{
	float total = 0;
	float frequency = noiseFrequency;
	float amplitude = noiseGain;

	for (int i = 0; i < 8; i++)
	{
		total += tex2D(baseSampler, (position / 1.8) * frequency) * amplitude;
		frequency *= noiseLacunarity;
		amplitude *= noiseGain;
	}

	return total;
}

float4 PixelShaderFunction(float2 texCoords:TEXCOORD0) : COLOR0
{
	/*
	float2 p = (texCoords);
	float2 q = float2(noise(p * 2.3), noise(p * 2.3));
	float2 r = noise(p / 4 + 0.2);
	float total = noise(p + 4.0 * r);
	*/

	float total = noise(texCoords * (renderTargetSize / randomTextureSize) / randomTextureScale);
	float4 color = float4(total, total, total, 1);

	return color;
}

technique Main
{
    pass Base
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}
