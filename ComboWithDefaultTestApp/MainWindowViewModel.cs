using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace ComboWithDefaultTestApp
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _defValue = "A";
        public string DefValue { get => _defValue; set { Set(() => DefValue, ref _defValue, value); } }

        private string _SelectedItem;
        public string SelectedItem { get => _SelectedItem; set { Set(() => SelectedItem, ref _SelectedItem, value); } }

        private string _selectedValue = "B";
        public string SelectedValue { get => _selectedValue; set { Set(() => SelectedValue, ref _selectedValue, value); } }

        private string _textValue;
        public string TextValue { get => _textValue; set { Set(() => TextValue, ref _textValue, value); } }

        private ObservableCollection<string> _values = new ObservableCollection<string>(new string[] { "A", "B", "C", "D" });
        public ObservableCollection<string> Values { get => _values; set { Set(() => Values, ref _values, value); } }

        public MainWindowViewModel()
        {

        }
    }
}
