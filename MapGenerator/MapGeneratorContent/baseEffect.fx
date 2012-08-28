#include <noiseFunction.fx>

float4x4 matrixTransform;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform);
}

// Pixel shader
float4 PSBaseNoise(float2 texCoords:TEXCOORD0) : COLOR0
{
	float n = worley(texCoords).x;
	
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
