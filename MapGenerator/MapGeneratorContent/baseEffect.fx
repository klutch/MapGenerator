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
float4x4 matrixTransform;

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

	return float4(n, n, n, 1);
}

// Noise
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

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseNoise();
    }
}
