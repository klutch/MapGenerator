#include <noiseFunction.fx>

sampler baseSampler : register(s0);
float2 renderTargetSize;
float4x4 matrixTransform;

// Vertex shader
void VSBase(inout float4 color:COLOR0, inout float2 texCoord:TEXCOORD0, inout float4 position:SV_Position) 
{ 
	position = mul(position, matrixTransform); 
}

// Pixel shader
float4 PSBaseFlora(float2 texCoords:TEXCOORD0) : COLOR0
{
	return 0;
}

technique Main
{
    pass Base
    {
		VertexShader = compile vs_3_0 VSBase();
        PixelShader = compile ps_3_0 PSBaseFlora();
    }
}
