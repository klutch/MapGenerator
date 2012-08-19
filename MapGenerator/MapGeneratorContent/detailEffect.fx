#include <noiseFunction.fx>

float4x4 matrixTransform;
float2 position;
float scale;
float2 renderTargetSize;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSWorleyNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float2 p = position / renderTargetSize - texCoords * float2(renderTargetSize.x / renderTargetSize.y, 1);

	float total = worley(texCoords - position / renderTargetSize);
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