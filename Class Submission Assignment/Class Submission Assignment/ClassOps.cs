using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class ClassOps
    {
        public void Divide(int numA, out int numB)
        {
            if ((numA % 2)== 0)
            {
                numB = numA / 2;
            }
            else
            {
                numB = -1;
            }
        }
        public void Divide(string numA, out int numB)
        {
            Divide(Convert.ToInt32(numA), out numB);
        }
    }
}
