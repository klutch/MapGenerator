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
bool fbm1NoiseOnly;
bool fbm2NoiseOnly;
bool fbm3NoiseOnly;
float2 fbm1Offset;
float2 fbm2Offset;
float2 fbm3Offset;
float fbm1Opacity;
float fbm2Opacity;
float fbm3Opacity;
float4 noiseLowColor;
float4 noiseHighColor;

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
	{
		float2 coords = fbm1NoiseOnly ?
			noise(baseSampler, p, noiseFrequency, noiseGain, noiseLacunarity) : 
			p + n * fbm1Offset;
		n *= lerp(n, noise(baseSampler, coords, noiseFrequency, noiseGain, noiseLacunarity), fbm1Opacity);
	}

	if (fbm2)
	{
		float2 coords = fbm2NoiseOnly ? 
			noise(baseSampler, p, noiseFrequency, noiseGain, noiseLacunarity) :
			p + n * fbm2Offset;
		n *= lerp(n, noise(baseSampler, coords, noiseFrequency, noiseGain, noiseLacunarity), fbm2Opacity);
	}

	if (fbm3)
	{
		float2 coords = fbm3NoiseOnly ?
		noise(baseSampler, p, noiseFrequency, noiseGain, noiseLacunarity) :
		p + n * fbm3Offset;
		n *= lerp(n, noise(baseSampler, coords, noiseFrequency, noiseGain, noiseLacunarity), fbm3Opacity);
	}

	n *= brightness;

	return lerp(noiseLowColor, noiseHighColor, n);

	//return float4(n, n, n, 1);
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseNoise();
    }
}
