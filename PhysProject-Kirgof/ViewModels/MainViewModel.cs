using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using PhysProject_Kirgof.Annotations;
using PhysProject_Kirgof.Models;
using PhysProject_Kirgof.Tools;
using System.Windows.Shapes;
using System.Windows.Controls;
using System;

namespace PhysProject_Kirgof.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private double _res1, _res2, _res3;

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

        public string Data1 => $"I1 = {I1} A";
        public string Data2 => $"I2 = {I2} A";
        public string Data3 => $"I3 = {I3} A";


        public double I1
        {
            get => Math.Round(_res1, 3);
            set
            {
                _res1 = value;
                OnPropertyChanged(nameof(I1));
                OnPropertyChanged(nameof(Data1));
            }
        }

        public double I2
        {
            get => Math.Round(_res2, 3);
            set
            {
                _res2 = value;
                OnPropertyChanged(nameof(I2));
                OnPropertyChanged(nameof(Data2));

            }
        }

        public double I3
        {
            get => Math.Round(_res3, 3);
            set
            {
                _res3 = value;
                OnPropertyChanged(nameof(I3));
                OnPropertyChanged(nameof(Data3));

            }
        }
     
        public ICommand Test
        {
            get
            {
                return new ActionCommand(() =>
                {
                    //var res = 0;
                    if ((First.IsEnable) && (Second.IsEnable) && (Third.IsEnable))
                    {
                        I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                        I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                        I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                    }

                    if ((First.IsEnable) && (!Second.IsEnable) && (Third.IsEnable))
                    {
                        Second.Value = 0.000000001F;
                        I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                        I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                        I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                    }

                    if ((!First.IsEnable) && (Second.IsEnable) && (Third.IsEnable))
                    {
                        First.Value = 0;
                        I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                        I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                        I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                    }

                    if ((!First.IsEnable) && (!Second.IsEnable) && (Third.IsEnable))
                    {
                        First.Value = 0;
                        Second.Value = 0;
                        I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                        I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                        I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                    }

                    if ((!First.IsEnable) && (!Second.IsEnable) && (!Third.IsEnable))
                    {
                        First.Value = 0;
                        Second.Value = 0;
                        Third.Value = 0;
                        I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                        I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                        I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                    }


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