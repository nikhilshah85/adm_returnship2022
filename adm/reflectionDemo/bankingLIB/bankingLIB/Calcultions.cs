using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankingLIB
{
    internal class Calcultions
    {
        public int FirstNumber { get; set; }
        public string SecondNumber { get; set; }


        public Calcultions()
        {

        }
        public Calcultions(int num1, int num2, int num3)
        {

        }

        public Calcultions(string name)
        {

        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        public int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        public int SimpleIntrest(int principal,int roi, int duration)
        {
            return (principal * roi / 100 ) * duration;
        }
    }
}







