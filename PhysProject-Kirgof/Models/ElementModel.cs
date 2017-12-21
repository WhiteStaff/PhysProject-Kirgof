using PhysProject_Kirgof.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PhysProject_Kirgof.Models
{
    public class ElementModel : INotifyPropertyChanged
    {
        public event EventHandler OnStateChanged;

        private int _value;
        private object set;

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

       
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
