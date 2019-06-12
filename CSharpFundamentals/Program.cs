using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpFundamentals.Math.Calculator;

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3 
    }

    class Program
    {
        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);

            Console.WriteLine(number);

            var person = new Person() {Age =20};
            MakeOld(person);

            Console.WriteLine(person.Age);
            /* Reference types
             var a = 10;
             
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};

            var array2 = array1;
            array2[0] = 0;

            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            */
            /*Conversions
             var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //convert Id to shipping method
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);
            */


            /* Arrary
            var firstName = "Tiana";
            var lastName = "Anderson";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] {"John", "jack", "Mary"};
            var formattedNames = string.Join(",", names);


            var text = @"Hi John
Look into the following paths
c:\filder1\folder2
c:\filder3\folder4";


            Console.WriteLine(text);
            */

            //Ex int, bool, string
            /*
            var numbers = new int [3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Mary"};
            //names[0] = "Tiana";

            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            */

            //Strings
            /*
            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            var addition = calculator.Add(100, 2);
            var subtraction = calculator.Subtract(100, 2);
            var multiplication = calculator.Multiply(100, 2);
            var division = calculator.Divide(100, 2);
            var doubled = calculator.Doubled(100);
            var half = calculator.Half(100);
            var third = calculator.Third(100);
            var quartered = calculator.Quarter(100);



            Console.WriteLine("The numbers are 100 and 2");
            Console.WriteLine("Addition result is:" + addition);
            Console.WriteLine("Subtraction result is:" + subtraction);
            Console.WriteLine("Mutlipication result is:" + multiplication);
            Console.WriteLine("Division result is:" + division);

            Console.WriteLine("doubled result is:" + doubled);
            Console.WriteLine("third result is:" + third);
            Console.WriteLine("quartered result is:" + quartered);
            Console.WriteLine("half result is:" + half);
            //Console.WriteLine(Pie);
            */
        }


    }
}
