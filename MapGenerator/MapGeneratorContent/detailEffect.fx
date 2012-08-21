#include <noiseFunction.fx>

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

	float total = worley(p);
	return float4(total, total, total, 1);
}

technique Main
{
    pass Worley
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSWorleyNoise();
    }
}