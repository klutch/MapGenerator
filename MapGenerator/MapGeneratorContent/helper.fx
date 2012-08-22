// XNA uses the March 2009 directx sdk, which has a buggy hlsl compiler that tries to
// use 'preshaders'. Disabling preshaders allows the shader to compile, but there's no way
// to do that from Visual Studio (that I'm aware of). Things like saturate, clamp, abs, etc
// can't be used on external parameters in Release mode with preshaders enabled, so I have
// to write my own absolute function :(
float absolute(float value)
{
	return sqrt(value * value);
}