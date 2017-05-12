using System;
using System.Collections.Generic;

namespace SEM03.Statistics
{
    public class Stat
    {
        private readonly double[] _t90 =
        {
            6.3138, 2.9200, 2.3534, 2.1319, 2.0150, 1.9432, 1.8946, 1.8595, 1.8331, 1.8124,
            1.7959, 1.7823, 1.7709, 1.7613, 1.7530, 1.7459, 1.7396, 1.7341, 1.7291, 1.7247,
            1.7207, 1.7172, 1.7139, 1.7109, 1.7081, 1.7056, 1.7033, 1.7011, 1.6991, 1.6449
        };

        private readonly double[] _t95 =
        {
            12.7065, 4.3026, 3.1824, 2.7764, 2.5706, 2.4469, 2.3646, 2.3060, 2.2621, 2.2282,
            2.2010, 2.1788, 2.1604, 2.1448, 2.1314, 2.1199, 2.1098, 2.1009, 2.0930, 2.0860,
            2.0796, 2.0739, 2.0686, 2.0639, 2.0596, 2.0555, 2.0518, 2.0484, 2.0452, 1.9600
        };

        private readonly double[] _t99 =
        {
            63.6551, 9.9247, 5.8408, 4.6041, 4.0322, 3.7074, 3.4995, 3.3554, 3.2498, 3.1693,
            3.1058, 3.0545, 3.0123, 2.9768, 2.9467, 2.9208, 2.8983, 2.8784, 2.8609, 2.8454,
            2.8314, 2.8188, 2.8073, 2.7970, 2.7874, 2.7787, 2.7707, 2.7633, 2.7564, 2.5758
        };

        private readonly OSPABA.Simulation _mySim;

        private double _sum;
        private double _sumSquare;
        private int _n;
        private double _min;
        private double _max;

        public double IgnoreBefore { get; set; }
        public double IgnoreAfter { get; set; }

        public int Samples => _n;

        public double Sum => _sum;
        public double Mean => _n == 0 ? 0.0 : _sum / _n;
        public double Variance => _n == 0 ? 0.0 : _sumSquare / _n - _sum / _n * (_sum / _n);
        public double Stdev => _n == 0 ? 0.0 : Math.Sqrt(Variance);
        public double Min => _n == 0 ? 0.0 : _min;
        public double Max => _n == 0 ? 0.0 : _max;

        public double[] ConfidenceInterval90 => ConfidenceInterval(_t90);
        public double[] ConfidenceInterval95 => ConfidenceInterval(_t95);
        public double[] ConfidenceInterval99 => ConfidenceInterval(_t99);

        public Stat(OSPABA.Simulation mySim)
        {
            _mySim = mySim;
            IgnoreBefore = 0.0;
            IgnoreAfter = double.MaxValue;
            Clear();
        }

        public Stat(Stat original)
        {
            _mySim = original._mySim;
            IgnoreBefore = original.IgnoreBefore;
            IgnoreAfter = original.IgnoreAfter;
            _sum = original._sum;
            _sumSquare = original._sumSquare;
            _n = original._n;
            _min = original._min;
            _max = original._max;
        }

        public void AddSample(double sample)
        {
            if (_mySim.CurrentTime < IgnoreBefore || _mySim.CurrentTime > IgnoreAfter)
            {
                return;
            }

            _sum += sample;
            _sumSquare += sample * sample;
            if (sample < _min) _min = sample;
            if (sample > _max) _max = sample;
            ++_n;
        }

        public void Clear()
        {
            _sum = 0.0;
            _sumSquare = 0.0;
            _n = 0;
            _min = double.MaxValue;
            _max = double.MinValue;
        }

        private double[] ConfidenceInterval(IReadOnlyList<double> tCrit)
        {
            if (_n < 2)
            {
                return new[] { double.NaN, double.NaN };
            }

            var quantile = _n > tCrit.Count ? tCrit[tCrit.Count - 1] : tCrit[_n - 2]; // n - 1 degrees of freedom
            var num = quantile * Stdev / Math.Sqrt(_n - 1);
            return new[] { Mean - num, Mean + num };
        }
    }
}
