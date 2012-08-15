float2 frequencyModifier[] = 
{
	float2(1, 1),
	float2(1, 0.5),
	float2(0.5, 1),
	float2(0.5, 0.5),
	float2(0.3, 0.3),
	float2(0.3, 0.15),
	float2(0.15, 0.3),
	float2(0.15, 0.15)
};

// Noise
float noise(sampler noiseSampler, float2 position, float frequency, float gain, float lacunarity)
{
	float total = 0;
	float amplitude = gain;

	float signModifier = 1;
	for (int i = 0; i < 8; i++)
	{
		total += tex2D(noiseSampler, (position / 1.8) * frequency * signModifier * frequencyModifier[i]) * amplitude;
		frequency *= lacunarity;
		amplitude *= gain;
		signModifier *= -1;
	}

	return total;
}