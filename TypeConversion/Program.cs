using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //var number = "1234";
                ////int i = Convert.ToInt32(number);
                ////Console.WriteLine(number);

                //byte b = Convert.ToByte(number);
                //Console.WriteLine(number);

                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);

            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte.");
            }
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);


            //Casting as byte
            //int i = 1;
            //byte b = (byte) i;
            //Console.WriteLine(b);

            


        }
    }
}
