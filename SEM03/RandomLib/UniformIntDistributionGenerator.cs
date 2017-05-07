using System;

namespace RandomLib
{
    public class UniformIntDistributionGenerator : Generator<int>
    {
        private Random _gen;

        public int Min { get; }
        public int Max { get; } // exclusive

        public UniformIntDistributionGenerator(int min, int max)
        {
            Min = min;
            Max = max;
            _gen = new Random();
        }

        public UniformIntDistributionGenerator(int min, int max, int seed)
        {
            Min = min;
            Max = max;
            _gen = new Random(seed);
        }

        public override void Seed(int seed)
        {
            _gen = new Random(seed);
        }

        public override int Next()
        {
            return _gen.Next(Min, Max);
        }
    }
}
