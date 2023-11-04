using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_LOGICAL_OPERATORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////LOGICAL OPERATORS//////////////////////////////////////////

            // && - BOTH STATEMENT TRUE
            // || - OR means either of the statement have true value

            int num1 = 5;
            int num2 = 10;

            //false
            if(num1 >= 6 && num2 == num1)// if && it need to have the 2 conditions to be both true
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("False");
            }

            // true
            if (num1 == 5 && num1 <= num2)// if && it need to have the 2 conditions to be both true
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("False");
            }

            //true
            if (num1 == 5 || num1 >= num2)// if || it need to have the 1 condition to be true
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("False");
            }

            //false
            if (num1 == 6 || num1 >= num2)// if || it need to have the 1 condition to be true
            {
                Console.WriteLine("Hello");
            }
            else
            {
                Console.WriteLine("False");
            }


            Console.ReadKey();
        }
    }
}
