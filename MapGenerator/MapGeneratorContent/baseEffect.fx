#include <noiseFunction.fx>

float2 offset;
float noiseFrequency;
float noiseGain;
float noiseLacunarity;
float brightness;

bool fbm1;
bool fbm2;
bool fbm3;
float2 fbm1Offset;
float2 fbm2Offset;
float2 fbm3Offset;
bool fbm1Perlin;
bool fbm2Perlin;
bool fbm3Perlin;
bool fbm1Cell;
bool fbm2Cell;
bool fbm3Cell;
bool fbm1InvCell;
bool fbm2InvCell;
bool fbm3InvCell;
float fbm1Scale;
float fbm2Scale;
float fbm3Scale;
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
	float smallSide = min(renderSize.x, renderSize.y);
	float2 aspect = renderSize / smallSide;
	float2 p = 
		(offset / renderSize) - (texCoords * aspect) / noiseScale;

	// Calculate noise
	float n = fbmPerlin(p, noiseFrequency, noiseGain, noiseLacunarity);
	
	if (fbm1)
	{
		float n1 = 0;
		float n1Scale = max(0.00001, fbm1Scale);
		float2 coords = (p + n * fbm1Offset) / n1Scale;
		if (fbm1Perlin)
			n1 = fbmPerlin(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else if (fbm1Cell)
			n1 = fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else
			n1 = 1 - fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);

		n *= n1;
	}

	if (fbm2)
	{
		float n2 = 0;
		float n2Scale = max(0.00001, fbm2Scale);
		float2 coords = (p + n * fbm2Offset) / n2Scale;
		if (fbm2Perlin)
			n2 = fbmPerlin(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else if (fbm2Cell)
			n2 = fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else
			n2 = 1 - fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);

		n *= n2;
	}

	if (fbm3)
	{
		float n3 = 0;
		float n3Scale = max(0.00001, fbm3Scale);
		float2 coords = (p + n * fbm3Offset) / n3Scale;
		if (fbm3Perlin)
			n3 = fbmPerlin(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else if (fbm3Cell)
			n3 = fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);
		else
			n3 = 1 - fbmWorley(coords, noiseFrequency, noiseGain, noiseLacunarity);

		n *= n3;
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
