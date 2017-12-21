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
            double r0 = 0.0001;

            if ((R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {                 
                I1 = (E1.Value - R3.Value * ((R2.Value * E1.Value + E2.Value * R1.Value) / (R1.Value * R2.Value + R2.Value * R3.Value + R1.Value * R3.Value))) / R1.Value;    
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                
                I1 = (E1.Value - R3.Value * ((r0 * E1.Value + E2.Value * R1.Value) / (R1.Value * r0 + r0 * R3.Value + R1.Value * R3.Value))) / R1.Value;
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {
                I1 = (E1.Value - R3.Value * ((R2.Value * E1.Value + E2.Value * r0) / (r0 * R2.Value + R2.Value * R3.Value + r0 * R3.Value))) / r0;
            }
            else
            if ((R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I1 = E1.Value / R1.Value;
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                I1 = (E1.Value - R3.Value * ((r0 * E1.Value + E2.Value * r0) / (r0 * r0 + r0 * R3.Value + r0 * R3.Value))) / r0;
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I1 = E1.Value / r0;
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I1 = E1.Value / R1.Value;
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I1 = 0;  
            } 

            return I1;
        }

        public static double ResultI2(ResistorModel R1, ResistorModel R2, ResistorModel R3, ElementModel E1, ElementModel E2)
        {
            double I2 = 0;
            double r0 = 0.0001;

            if ((R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {
                I2 = (E2.Value - R3.Value * ((R2.Value * E1.Value + E2.Value * R1.Value) / (R1.Value * R2.Value + R2.Value * R3.Value + R1.Value * R3.Value))) / R2.Value;
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                I2 = (E2.Value - R3.Value * ((r0 * E1.Value + E2.Value * R1.Value) / (R1.Value * r0 + r0 * R3.Value + R1.Value * R3.Value))) / r0;
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {
                I2 = (E2.Value - R3.Value * ((R2.Value * E1.Value + E2.Value * r0) / (r0 * R2.Value + R2.Value * R3.Value + r0 * R3.Value))) / R2.Value;
            }
            else
            if ((R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I2 = E2.Value / R2.Value;
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                I2 = (E2.Value - R3.Value * ((r0 * E1.Value + E2.Value * r0) / (r0 * r0 + r0 * R3.Value + r0 * R3.Value))) / r0;
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I2 = E2.Value / R2.Value;
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I2 = E1.Value / r0;
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I2 = 0;
            }

            return I2;
        }

        public static double ResultI3(ResistorModel R1, ResistorModel R2, ResistorModel R3, ElementModel E1, ElementModel E2)
        {
            double I3 = 0;
            double r0 = 0.0001;

            if ((R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {
                I3 = (R2.Value * E1.Value + E2.Value * R1.Value) / (R1.Value * R2.Value + R2.Value * R3.Value + R1.Value * R3.Value);
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                I3 = (r0 * E1.Value + E2.Value * R1.Value) / (R1.Value * r0 + r0 * R3.Value + R1.Value * R3.Value);
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (R3.IsEnable))
            {
                I3 = (R2.Value * E1.Value + E2.Value * r0) / (r0 * R2.Value + R2.Value * R3.Value + r0 * R3.Value);
            }
            else
            if ((R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I3 = (E1.Value / R1.Value) + (E2.Value / R2.Value);
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (R3.IsEnable))
            {
                I3 = (r0 * E1.Value + E2.Value * r0) / (r0 * r0 + r0 * R3.Value + r0 * R3.Value);
            }
            else
            if ((!R1.IsEnable) && (R2.IsEnable) && (!R3.IsEnable))
            {
                I3 = (E1.Value / r0) + (E2.Value / R2.Value);
            }
            else
            if ((R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I3 = (E1.Value / R1.Value) + E1.Value / r0;
            }
            else
            if ((!R1.IsEnable) && (!R2.IsEnable) && (!R3.IsEnable))
            {
                I3 = 0;
            }     

            return I3;
        }

    }
}
