using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace win32_inpc
{
    public class MainViewModel : INotifyPropertyChanged
    {

        private int _clickCount;
        
        public int ClickCount
        {
            get => _clickCount;
            set => SetValue(ref _clickCount, value);
        }

        private string _buttonContent = "Click me";
        public string ButtonContent
        {
            get => _buttonContent;
            set => SetValue(ref _buttonContent, value);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void SetValue<T>(ref T currentValue, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(currentValue, newValue))
            {
                currentValue = newValue;
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
