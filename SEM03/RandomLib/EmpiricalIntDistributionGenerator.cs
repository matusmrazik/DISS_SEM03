using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomLib
{
    public class EmpiricalIntDistributionGenerator : Generator<int>
    {
        private readonly List<double> _probs;
        private readonly List<UniformIntDistributionGenerator> _dists;
        private Random _gen;

        public EmpiricalIntDistributionGenerator(IntervalDefinition[] intervalDefinitions)
        {
            _probs = new List<double>();
            _dists = new List<UniformIntDistributionGenerator>();
            _gen = new Random();
            var sum = intervalDefinitions.Sum(definition => definition.Prob);
            var d = 0.0;
            foreach (var definition in intervalDefinitions)
            {
                d += definition.Prob;
                _probs.Add(d / sum);
                _dists.Add(new UniformIntDistributionGenerator(definition.Min, definition.Max));
            }
        }

        public EmpiricalIntDistributionGenerator(IntervalDefinition[] intervalDefinitions, int seed)
            : this(intervalDefinitions)
        {
            Seed(seed);
        }

        public override void Seed(int seed)
        {
            var seedGen = new Random(seed);
            _gen = new Random(seedGen.Next());
            foreach (var item in _dists)
            {
                item.Seed(seedGen.Next());
            }
        }

        public override int Next()
        {
            var u = _gen.NextDouble();
            var index = _probs.BinarySearch(u);
            if (index < 0) index = ~index;
            return _dists[index].Next();
        }

        public struct IntervalDefinition
        {
            public int Min { get; }
            public int Max { get; }
            public double Prob { get; }

            public IntervalDefinition(int min, int max, double prob)
            {
                Min = min;
                Max = max;
                Prob = prob;
            }
        }
    }
}
