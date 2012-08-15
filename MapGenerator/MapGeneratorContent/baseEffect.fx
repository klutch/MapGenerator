#include <noiseFunction.fx>

sampler baseSampler : register(s0) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
};

float2 randomTextureSize;
float2 renderTargetSize;

float2 position;
float scale;
float noiseFrequency;
float noiseGain;
float noiseLacunarity;
float brightness;

bool fbm1;
bool fbm2;
bool fbm3;
float fbm1Divisor;
float fbm2Divisor;
float fbm3Divisor;

float4x4 matrixTransform;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSBaseNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	// Set position
	float2 p = 
		(position / renderTargetSize) - 
		texCoords * (renderTargetSize / randomTextureSize) / scale;

	// Calculate noise
	float n = noise(baseSampler, p, noiseFrequency, noiseGain, noiseLacunarity);
	
	if (fbm1)
		n *= noise(baseSampler, p + n / fbm1Divisor, noiseFrequency, noiseGain, noiseLacunarity);

	if (fbm2)
		n *= noise(baseSampler, p + n / fbm2Divisor, noiseFrequency, noiseGain, noiseLacunarity);

	if (fbm3)
		n *= noise(baseSampler, p + n / fbm3Divisor, noiseFrequency, noiseGain, noiseLacunarity);

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
