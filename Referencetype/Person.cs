using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Day1_opg3.Referencetype
{
    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public double Vægt { get; set; }
        public double Højde { get; set; }
        public double BMI
        {
            get { return Vægt / (Højde * Højde); }
        }
    }
}
