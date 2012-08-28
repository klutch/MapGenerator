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
	float2 n = worley(texCoords);
	float w = n.y;
	return float4(w, w, w, 1);
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseNoise();
    }
}
