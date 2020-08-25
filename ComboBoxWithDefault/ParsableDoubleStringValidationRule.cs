using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace ComboBoxWithDefaultProj
{
    public class ParsableDoubleStringValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
       {
            try
            {
                string normalized = ((string)value).Replace(",", ".");
                double.Parse(normalized, NumberStyles.Any, CultureInfo.InvariantCulture);
                return ValidationResult.ValidResult;
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, ex.Message);
            }   
                
        }
    }
}
