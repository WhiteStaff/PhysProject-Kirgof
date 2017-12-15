using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PhysProject_Kirgof.Annotations;

namespace PhysProject_Kirgof.Models
{
    public class ResistorModel : INotifyPropertyChanged
    {
        public event EventHandler OnStateChanged;

        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged(nameof(Value));
                OnStateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private bool _isEnable;
        public bool IsEnable
        {
            get => _isEnable;
            set
            {
                _isEnable = value;
                OnPropertyChanged(nameof(IsEnable));
                OnStateChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}