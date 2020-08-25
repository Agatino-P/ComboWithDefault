using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ComboBoxWithDefaultProj
{
    /// <summary>
    /// Interaction logic for ComboBoxWithDefault.xaml
    /// </summary>
    public partial class ComboBoxWithDefault : UserControl
    {

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(ComboBoxWithDefault), new PropertyMetadata(null));

        public double DefaultValue
        {
            get { return (double)GetValue(DefaultValueProperty); }
            set { SetValue(DefaultValueProperty, value); }
        }

        public static readonly DependencyProperty DefaultValueProperty =
            DependencyProperty.Register("DefaultValue", typeof(double), typeof(ComboBoxWithDefault), new PropertyMetadata(0d, OnDefaultValueChanged));

        private static void OnDefaultValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = e.NewValue;
            if (!(d is ComboBoxWithDefault cbwd))
                return;
            cbwd.DoubleValue = cbwd.DefaultValue;
        }
       
        public double DoubleValue
        {
            get { return (double)GetValue(DoubleValueProperty); }
            set { SetValue(DoubleValueProperty, value); }
        }
        public static readonly DependencyProperty DoubleValueProperty =
            DependencyProperty.Register("DoubleValue", typeof(double), typeof(ComboBoxWithDefault), new FrameworkPropertyMetadata(0d, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, OnDoubleValueChanged));
        private static void OnDoubleValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = e.NewValue;
        }

        public List<double> Values
        {
            get { return (List<double>)GetValue(ValuesProperty); }
            set { SetValue(ValuesProperty, value); }
        }
        public static readonly DependencyProperty ValuesProperty =
            DependencyProperty.Register("Values", typeof(List<double>), typeof(ComboBoxWithDefault), new PropertyMetadata(null, OnValuesChanged));
        private static void OnValuesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var a = e.NewValue;
        }

        public ComboBoxWithDefault()
        {
            InitializeComponent();
            DoubleValue = DefaultValue;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            DoubleValue = DefaultValue;
        }
    }
}
