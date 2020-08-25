using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ComboBoxWithDefaultProj
{
    public partial class ComboBoxWithDefault : UserControl
    {

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(ComboBoxWithDefault), new PropertyMetadata(null));

        public bool ShowDefaultButton
        {
            get { return (bool)GetValue(ShowDefaultButtonProperty); }
            set { SetValue(ShowDefaultButtonProperty, value); }
        }
        public static readonly DependencyProperty ShowDefaultButtonProperty =
            DependencyProperty.Register("ShowDefaultButton", typeof(bool), typeof(ComboBoxWithDefault), new PropertyMetadata(true));


        public double DefaultValue
        {
            get { return (double)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }
        public static readonly DependencyProperty DefaultValueProperty =
            DependencyProperty.Register("DefaultValue", typeof(double), typeof(ComboBoxWithDefault), new PropertyMetadata(0d));

       
        public double DoubleValue
        {
            get { return (double)GetValue(DoubleValueProperty); }
            set { SetValue(DoubleValueProperty, value); }
        }
        public static readonly DependencyProperty DoubleValueProperty =
            DependencyProperty.Register("DoubleValue", typeof(double), typeof(ComboBoxWithDefault), 
                new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, onDoubleValueChanged));

        private static void onDoubleValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (!(d is ComboBoxWithDefault cbwd))
                return;
            cbwd.DifferentFromDefault = cbwd.DoubleValue != cbwd.DefaultValue;
        }

        public bool DifferentFromDefault
        {
            get { return (bool)GetValue(DifferentFromDefaultProperty); }
            set { SetValue(DifferentFromDefaultProperty, value); }
        }
        public static readonly DependencyProperty DifferentFromDefaultProperty =
            DependencyProperty.Register("DifferentFromDefault", typeof(bool), typeof(ComboBoxWithDefault), new PropertyMetadata(false));

        public List<double> Values
        {
            get { return (List<double>)GetValue(ValuesProperty); }
            set { SetValue(ValuesProperty, value); }
        }
        public static readonly DependencyProperty ValuesProperty =
            DependencyProperty.Register("Values", typeof(List<double>), typeof(ComboBoxWithDefault), new PropertyMetadata(null));


        public ComboBoxWithDefault()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            DoubleValue = DefaultValue;
        }
    }
}
