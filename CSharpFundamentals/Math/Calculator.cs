using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Math
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public float Divide(int a, int b)
        {
            return a / b;
        }

        public float Doubled(int a)
         {
            return a * 2;
         }

        public float Half(int a)
        {
            return a / 2;
        }

        public float Third(int a)
        {
            return a / 3;
        }

        public  float Quarter(int a)
        {
            return a / 4;
        }

    }
}
