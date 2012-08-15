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
float brightness;

float4x4 matrixTransform;

float2 frequencyModifier[] = 
{
	float2(1, 1),
	float2(1, 0.5),
	float2(0.5, 1),
	float2(0.5, 0.5),
	float2(0.3, 0.3),
	float2(0.3, 0.15),
	float2(0.15, 0.3),
	float2(0.15, 0.15)
};

// Noise
float noise(float2 position)
{
	float total = 0;
	float frequency = noiseFrequency;
	float amplitude = noiseGain;

	float signModifier = 1;
	for (int i = 0; i < 8; i++)
	{
		total += tex2D(baseSampler, (position / 1.8) * frequency * signModifier * frequencyModifier[i]) * amplitude;
		frequency *= noiseLacunarity;
		amplitude *= noiseGain;
		signModifier *= -1;
	}

	return total;
}

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSBaseNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float2 p = texCoords * (renderTargetSize / randomTextureSize) / randomTextureScale;
	float n = noise(p);
	n *= noise(p + n / 2);
	n *= noise(p + n / 4);
	n *= noise(p + n / 8);
	
	n *= brightness;

	return float4(n, n, n, 1);
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseNoise();
    }
}
