using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day1_opg3.Valuetypes
{
    public class Measurement
    {
        public double BMI { get; }

        public Measurement(double vægt, double højde)
        {
            BMI = vægt / (højde * højde);
        }
    }
}
