using System;
using System.Collections.Generic;
using System.Printing.IndexedProperties;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ComboBoxWithDefault
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

        public object Default
        {
            get { return (object)GetValue(DefaultProperty); }
            set { SetValue(DefaultProperty, value); }
        }
        public static readonly DependencyProperty DefaultProperty =
            DependencyProperty.Register("Default", typeof(object), typeof(ComboBoxWithDefault), new PropertyMetadata(null));

        public object Selected
        {
            get { return (object)GetValue(SelectedProperty); }
            set { SetValue(SelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Selected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(object), typeof(ComboBoxWithDefault), new PropertyMetadata(null));


        public IEnumerable<Object> Values
        {
            get { return (IEnumerable<Object>)GetValue(ValuesProperty); }
            set { SetValue(ValuesProperty, value); }
        }

        public static readonly DependencyProperty ValuesProperty =
            DependencyProperty.Register("Values", typeof(IEnumerable<Object>), typeof(ComboBoxWithDefault), new PropertyMetadata(null));

        public ComboBoxWithDefault()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Selected = Default;
        }
    }
}
