using System;

namespace RandomLib
{
    public class ExponentialDistributionGenerator : Generator<double>
    {
        private Random _gen;

        public double Mean { get; }

        public ExponentialDistributionGenerator(double mean)
        {
            Mean = mean;
            _gen = new Random();
        }

        public ExponentialDistributionGenerator(double mean, int seed)
        {
            Mean = mean;
            _gen = new Random(seed);
        }

        public override void Seed(int seed)
        {
            _gen = new Random(seed);
        }

        public override double Next()
        {
            return -Mean * Math.Log(1.0 - _gen.NextDouble());
        }
    }
}
