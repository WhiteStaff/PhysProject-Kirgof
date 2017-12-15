using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PhysProject_Kirgof.Annotations;
using PhysProject_Kirgof.Models;
using PhysProject_Kirgof.Tools;

namespace PhysProject_Kirgof.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int _res;

        public MainViewModel()
        {
            First = new ResistorModel
            {
                Value = 0,
                IsEnable = true
            };
            Second = new ResistorModel
            {
                Value = 0,
                IsEnable = true
            };
            Third = new ResistorModel
            {
                Value = 0,
                IsEnable = true
            };
            FirstElement = new ElementModel
            {
                Value = 0,
            };
            SecondElement = new ElementModel
            {
                Value = 0,
            };
        }

        public ElementModel FirstElement { get; set; }
        public ElementModel SecondElement { get; set; }
        public ResistorModel First { get; set; }
        public ResistorModel Second { get; set; }
        public ResistorModel Third { get; set; }

        public int Result
        {
            get => _res;
            set
            {
                _res = value;
                OnPropertyChanged(nameof(Result));
            }
        }

        public int ElementResult
        {
            get => _res;
            set
            {
                _res = value;
                OnPropertyChanged(nameof(ElementResult));
            }
        }

        public ICommand Test
        {
            get
            {
                return new ActionCommand(() =>
                {
                    var res = 0;
                    if (First.IsEnable) res += First.Value;
                    if (Second.IsEnable) res += Second.Value;
                    if (Third.IsEnable) res += Third.Value;
                    Result = res;
                    res = 0;
                    res += FirstElement.Value;
                    res += SecondElement.Value;
                    ElementResult = res;
                });
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}