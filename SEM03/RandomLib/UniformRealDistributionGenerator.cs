using System;

namespace RandomLib
{
    public class UniformRealDistributionGenerator : Generator<double>
    {
        private Random _gen;

        public double Min { get; }
        public double Max { get; }

        public UniformRealDistributionGenerator(double min, double max)
        {
            Min = min;
            Max = max;
            _gen = new Random();
        }

        public UniformRealDistributionGenerator(double min, double max, int seed)
        {
            Min = min;
            Max = max;
            _gen = new Random(seed);
        }

        public override void Seed(int seed)
        {
            _gen = new Random(seed);
        }

        public override double Next()
        {
            return Min + _gen.NextDouble() * (Max - Min);
        }
    }
}
