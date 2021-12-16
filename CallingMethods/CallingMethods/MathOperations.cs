using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class MathOperations
    {
        public MathOperations()
        {
            secondnumber = 10;
        }
        public int secondnumber { get; set; }

        //Method to Add 
        public int Addition(int numEntered)
        {
            return (secondnumber + numEntered);
        }

        //Method to Subtract
        public int Subtraction(int numEntered)
        {
            //return the result of the mathematical operation
            return (secondnumber - numEntered);
        }
        //Method to Multiply
        public int Multiplication(int numEntered)
        {
            //return the result of the mathematical operation
            return (secondnumber * numEntered);
        }
        //Method to Divide
        public int Division(int numEntered)
        {
            //return the result of the mathematical operation
            return (secondnumber / numEntered);
        }
    }
}
