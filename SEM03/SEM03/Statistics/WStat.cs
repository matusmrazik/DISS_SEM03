using System;

namespace SEM03.Statistics
{
    public class WStat
    {
        private readonly OSPABA.Simulation _mySim;

        private double _sum;
        private double _sumSquare;
        private int _n;
        private double _weightSum;
        private double _min;
        private double _max;
        private double _curValue;
        private double _curTime;

        public double IgnoreBefore { get; set; }
        public double IgnoreAfter { get; set; }

        public int Samples => _n;
        public double SampleSize => _weightSum;

        public double Mean => _n == 0 ? 0.0 : _sum / _weightSum;
        public double Variance => _n == 0 ? 0.0 : _sumSquare / _weightSum - _sum / _weightSum * (_sum / _weightSum);
        public double Stdev => _n == 0 ? 0.0 : Math.Sqrt(Variance);
        public double Min => _n == 0 ? 0.0 : _min;
        public double Max => _n == 0 ? 0.0 : _max;

        public WStat(OSPABA.Simulation mySim)
        {
            _mySim = mySim;
            IgnoreBefore = 0.0;
            IgnoreAfter = double.MaxValue;
            Clear();
        }

        public WStat(WStat original)
        {
            _mySim = original._mySim;
            IgnoreBefore = original.IgnoreBefore;
            IgnoreAfter = original.IgnoreAfter;
            _sum = original._sum;
            _sumSquare = original._sumSquare;
            _n = original._n;
            _weightSum = original._weightSum;
            _min = original._min;
            _max = original._max;
            _curValue = original._curValue;
            _curTime = original._curTime;
        }

        public void AddSample(double sample)
        {
            if (_mySim.CurrentTime <= IgnoreBefore || _curTime >= IgnoreAfter)
            {
                _curValue = sample;
                return;
            }

            var minTime = Math.Max(IgnoreBefore, _curTime);
            var maxTime = Math.Min(IgnoreAfter, _mySim.CurrentTime);
            var time = maxTime - minTime;

            _sum += _curValue * time;
            _sumSquare += _curValue * _curValue * time;
            ++_n;
            _weightSum += time;
            _curValue = sample;
            _curTime = _mySim.CurrentTime;
            if (sample < _min) _min = sample;
            if (sample > _max) _max = sample;
        }

        public void Clear()
        {
            _sum = 0.0;
            _sumSquare = 0.0;
            _n = 0;
            _weightSum = 0.0;
            _min = double.MaxValue;
            _max = double.MinValue;
            _curValue = 0.0;
            _curTime = _mySim.CurrentTime;
        }
    }
}
