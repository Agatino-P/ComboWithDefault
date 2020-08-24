using GalaSoft.MvvmLight;
using System.Collections.Generic;

namespace ComboWithDefaultTestApp
{
    public class MainWindowViewModel : ViewModelBase
    {
        private double _defaultValue = 1.1;
        public double DefaultValue { get => _defaultValue; set { Set(() => DefaultValue, ref _defaultValue, value); } }

        private double _doubleValue;
        public double DoubleValue
        {
            get => _doubleValue; 
            set
            {
                if (value != null)
                {
                    Set(() => DoubleValue, ref _doubleValue, value);
                }
            }
        }

        private List<double> _values = new List<double>(new double[] { 1.1, 2.2, 3.3, 4.4 });
        public List<double> Values { get => _values; set { Set(() => Values, ref _values, value); } }

        //private double _localDouble;
        //public double LocalDouble { get => _localDouble; set { Set(() => LocalDouble, ref _localDouble, value); }}

        public MainWindowViewModel()
        {

        }
    }
}
