////////////////////////////////////////////////////
// Perlin noise
////////////////////////////////////////////////////
float2 noiseSize;
float noiseScale;
float2 renderSize;
sampler noiseSampler : register(s1) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
	MinFilter = Point;
	MagFilter = Point;
	MipFilter = Point;
};

float weight(float x)
{
	return 6 * pow(x, 5) - 15 * pow(x, 4) + 10 * pow(x, 3);
}

float perlin(float2 p)
{
	// Scale texture coordinates from [0, 1] to [0, textureSize]
	float2 realPosition = p * noiseSize;

	// Grid points
	int x0 = floor(realPosition.x);
	int y0 = floor(realPosition.y);
	int x1 = x0 + 1;
	int y1 = y0 + 1;

	// Gradients
	float2 g00 = tex2D(noiseSampler, float2(x0, y0) / noiseSize).rg * 2 - 1;
	float2 g10 = tex2D(noiseSampler, float2(x1, y0) / noiseSize).rg * 2 - 1;
	float2 g01 = tex2D(noiseSampler, float2(x0, y1) / noiseSize).rg * 2 - 1;
	float2 g11 = tex2D(noiseSampler, float2(x1, y1) / noiseSize).rg * 2 - 1;

	// Position inside grid
	float u = realPosition.x - x0;
	float v = realPosition.y - y0;

	// Influence (dot product of gradient and distance to position from grid point)
	float n00 = dot(g00, float2(u, v));
	float n10 = dot(g10, float2(u - 1, v));
	float n01 = dot(g01, float2(u, v - 1));
	float n11 = dot(g11, float2(u - 1, v - 1));

	// Weighted contributions
	float nx0 = n00 * (1 - weight(u)) + n10 * weight(u);
	float nx1 = n01 * (1 - weight(u)) + n11 * weight(u);
	float nxy = nx0 * (1 - weight(v)) + nx1 * weight(v);

	//return (nxy + 1) / 2;
	return nxy;
}

///////////////////////////////////////////
// Worley noise
///////////////////////////////////////////
sampler worleySampler : register(s2) = sampler_state
{
	AddressU = Wrap;
	AddressV = Wrap;
};

float4 getWorleyCell(int x, int y, float jitter)
{
	float u = (x + y * 9) / noiseSize.x;
	float v = (x * 3) / noiseSize.y;
	return tex2D(worleySampler, float2(u, v)) * jitter;
}

float2 worley(float2 p, bool inverse = false, float jitter = 2.0)
{
	// Resize coords
	p *= 16;

	int xi = int(floor(p.x));
	int yi = int(floor(p.y));

	float xf = p.x - float(xi);
	float yf = p.y - float(yi);

	float distance1 = 9999999;
	float distance2 = 9999999;

	float2 cell;

	for (int y = -2; y <= 2; y++)
	{
		for (int x = -2; x <= 2; x++)
		{
			cell = getWorleyCell(xi + x, yi + y, jitter).rg;
			cell.x += (float(x) - xf);
			cell.y += (float(y) - yf);
			float distance = dot(cell, cell);
			if (distance < distance1)
			{
				distance2 = distance1;
				distance1 = distance;
			}
			else if (distance < distance2)
			{
				distance2 = distance;
			}
		}
	}

	if (inverse)
		return float2(sqrt(distance1), sqrt(distance2)) - 1;
	else
		return (1 - float2(sqrt(distance1), sqrt(distance2))) * 2 - 1;
}

///////////////////////////////////////////
// Fractional Brownian Motion
///////////////////////////////////////////
float fbmPerlin(float2 p, int count, float frequency, float gain, float lacunarity)
{
	float total = 0;
	float amplitude = gain;

	for (int i = 0; i < count; i++)
	{
		total += perlin(p * frequency) * amplitude;
		frequency *= lacunarity;
		amplitude *= gain;
	}

	return total;
}

float fbmWorley(float2 p, bool inverse, int count, float frequency, float gain, float lacunarity)
{
	float total = 0;
	float amplitude = gain;

	for (int i = 0; i < count; i++)
	{
		total += worley(p * frequency, inverse).x * amplitude;
		frequency *= lacunarity;
		amplitude *= gain;
	}

	return total;
}