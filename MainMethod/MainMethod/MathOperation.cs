using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathOperation
    {
        public MathOperation()
        {
            auxNumber = 5;
        }

        public int auxNumber { get; set; }

        public int Addition(int wholeNumber)
        {
            return wholeNumber + auxNumber;
        }

        //Addition Method with decimal parameter
        public int Addition(decimal decimalNumber)
        {
            return Convert.ToInt32(decimalNumber) + auxNumber;
        }

        //Addition Method with String parameter
        public int Addition(string stringNumber)
        {
            //if error, return to main.
            return Convert.ToInt32(stringNumber) + auxNumber;
        }
    }
}