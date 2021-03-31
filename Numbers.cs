using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Method
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number2;
            }

            else if (number1 > number2)
            {
                return number1;
            }

            return number1;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            int min;
            int a = (int)number3;
                if (number1 < number2 && number1 < a)
                {
                    min = number1;
                }
                else if (number2 < number1 && number2 < a)
                {
                    min = number2;
                }
                else
                {
                    min = a;
                }

            return min;

        }

        public int FindMaximum(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number2;
            }

            else if (number1 > number2)
            {
                return number1;
            }

            return number1;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            int max;
            int a = (int)number3;
            if (number1 > number2 && number1 > a)
            {
                max = number1;
            }

            else if (number2 > number1 && number2 > a)
            {
                max = number2;
            }

            else
            {
                max = a;
            }

            return max;
        }
    }
}
