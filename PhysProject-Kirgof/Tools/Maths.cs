using PhysProject_Kirgof.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysProject_Kirgof.Tools
{
    class Maths
    {
        public static double ResultI1(ResistorModel R1, ResistorModel R2, ResistorModel R3, ElementModel E1, ElementModel E2)
        {
            double I1 = 0;
            /*if ((R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {                 
                I1 = (E1.Value - R3.Value * (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value)) / First.Value;    
            }

            if ((First.IsEnable) && (!Second.IsEnable) && (Third.IsEnable))
            {
                Second.Value = 0.000000001F;
                I3 = (Second.Value * FirstElement.Value + SecondElement.Value * First.Value) / (First.Value * Second.Value + Third.Value * First.Value + Second.Value * Third.Value);
                I1 = (FirstElement.Value - Third.Value * I3) / First.Value;
                I2 = (SecondElement.Value - Third.Value * I3) / Second.Value;
                I3 = I1 + I2;
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
            }       */
            return I1;
        }

        public static double ResultI2(ResistorModel R1, ResistorModel R2, ResistorModel R3, ElementModel E1, ElementModel E2)
        {
            double I2 = 0;

            return I2;
        }

        public static double ResultI3(ResistorModel R1, ResistorModel R2, ResistorModel R3, ElementModel E1, ElementModel E2)
        {
            double I3 = 0;

            return I3;
        }

    }
}
