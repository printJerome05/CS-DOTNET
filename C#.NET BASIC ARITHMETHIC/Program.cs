using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_BASIC_ARITHMETHIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////BASIC ARITMETICS//////////////////////////////////////////////

            int number = 10;

            number = number + 5; // means number = 1 + 5
            Console.WriteLine(number);

            number += 5; // shortcut for plus 5 can - can add any digit you want not limited
            Console.WriteLine(number);

            number++; // it only adds 1 - limited only to 1
            Console.WriteLine(number);

            // MINUS
            number = number - 5; // means number = 1 + 5
            Console.WriteLine(number);

            number -= 5; // shortcut for plus 5 can - can add any digit you want not limited
            Console.WriteLine(number);

            number--; // it only adds 1 - limited only to 1
            Console.WriteLine(number);

            // MULTI
            number = number * 5; // means number = 1 + 5
            Console.WriteLine(number);

            number *= 5; // shortcut for plus 5 can - can add any digit you want not limited
            Console.WriteLine(number);

            // DIVISION
            number = number / 5; // means number = 1 + 5
            Console.WriteLine(number);

            number /= 5; // shortcut for plus 5 can - can add any digit you want not limited
            Console.WriteLine(number);

            //REMAINDER 
            number = 10;

            int div = number % 3; // % menans just returning the remainder of the divident 

            Console.WriteLine(div);


            /////////////////////////////////////MATH/////////////////////////////////////////

            double a = 3;

            double b = Math.Pow(a, 2); // it means power the 2 means the a will divide itself to 2
            Console.WriteLine(b);

            double c = Math.Sqrt(a);
            Console.WriteLine(c);

            int neg = -3;
            double d = Math.Abs(neg);// make the value postive
            Console.WriteLine(d);

            double ron = 3.14;

            double e = Math.Round(ron); // 
            Console.WriteLine(e);

            double f= Math.Ceiling(ron); // rounded up
            Console.WriteLine(f);

            double g = Math.Floor(ron); // rounded down
            Console.WriteLine(g);

            int num1 = 5;
            int num2 = 3;

            int num3 = Math.Max(num1, num2); // returning the maximum value of the 2;
            Console.WriteLine("MAX: "+num3);

            int num4 = Math.Min(num1, num2); // returning the minimum value of the 2;
            Console.WriteLine("MIN: "+num4);

            ///////////////////////////////////RANDOM NUMBER/////////////////////////////////////////
            
            Random rm = new Random(); // Instantiate random to have its function

            int rand = rm.Next(1, 7); // it means it ranges from 1 to 6
            Console.WriteLine("Random number: "+rand);






















            Console.ReadKey();
        }
    }
}
