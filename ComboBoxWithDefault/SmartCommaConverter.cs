using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;


namespace ComboBoxWithDefaultProj
{
    internal class SmartDoubleConverter : MarkupExtension, IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) //double to string
        {
            string retValue = null;
            if (value is double)
            {
                retValue = value.ToString().Replace(",", ".");
            }
            return retValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) //string to double 
        {
            double retValue = 0;
            if (value is string)
            {
                string normalized = value.ToString().Replace(",", ".");
                try
                {
                    retValue = double.Parse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    throw new FormatException(ex.Message);
                }
            }
            return retValue;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}