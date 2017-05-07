using System;

namespace RandomLib
{
    public class TriangularDistributionGenerator : Generator<double>
    {
        private Random _gen;

        public double Min { get; }
        public double Max { get; }
        public double Mod { get; }

        public TriangularDistributionGenerator(double min, double mod, double max)
        {
            Min = min;
            Max = max;
            Mod = mod;
            _gen = new Random();
        }

        public TriangularDistributionGenerator(double min, double mod, double max, int seed)
        {
            Min = min;
            Max = max;
            Mod = mod;
            _gen = new Random(seed);
        }

        public override void Seed(int seed)
        {
            _gen = new Random(seed);
        }

        public override double Next()
        {
            var u = _gen.NextDouble();
            var f = (Mod - Min) / (Max - Min);
            if (u < f)
                return Min + Math.Sqrt(u * (Mod - Min) * (Max - Min));
            return Max - Math.Sqrt((1.0 - u) * (Max - Min) * (Max - Mod));
        }
    }
}
