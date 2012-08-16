// Noise
float noise(sampler noiseSampler, float2 position, float frequency, float gain, float lacunarity)
{
	float total = 0;
	float amplitude = gain;

	for (int i = 0; i < 8; i++)
	{
		total += tex2D(noiseSampler, position * frequency) * amplitude;
		frequency *= lacunarity;
		amplitude *= gain;

	}

	return total;
}