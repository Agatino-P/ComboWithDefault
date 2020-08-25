using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace ComboWithDefaultTestApp
{
    public class MainWindowViewModel : ViewModelBase
    {
        private double _defaultValue = 1.1;
        public double DefaultValue { get => _defaultValue; set { Set(() => DefaultValue, ref _defaultValue, value); } }

        private double _value = 5.5;
        public double Value        { get => _value; set { Set(() => Value, ref _value, value); } }

        private List<double> _values = new List<double>(new double[] { 1.1, 2.2, 3.3, 4.4 });
        public List<double> Values { get => _values; set { Set(() => Values, ref _values, value); } }

        public MainWindowViewModel()
        {

        }
    }
}
