
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_CONDITIONAL_OPERATOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////CONDITIONAL OPERATOR//////////////////////////////////////////////
            // used in a condtional statement if a condition is true or false 
            // a shortcut for if else but only 2 statement only
            // (condition) ? x : y 
            // x is true
            // y is false
            // it is a return statement so it should be iterated like string
            // NEED TO console writeline it to show result

            int age = 22;

            string result = (age >= 18) ? "ADULT" : "TEENAGER";
            Console.WriteLine(result);

            age = 15;
            string result1 = (age >= 18) ? "Adult" : "teenager";
            Console.WriteLine(result1);
           


            Console.ReadKey();
        }
    }
}
