using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_FOR_EACH_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////FOR EACH LOOP////////////////////////////////////////////////
            // foreach = simpler version of for loop but it is not flexible
            // commonly use for printing array

            string[] names = { "JEROME","MARCO","MARA"};
            int[] numbers = { 1,2,3,4,5};

            foreach (string name in names) // it is like a nickname after the in it is the arrays true name.
            {
                Console.WriteLine(name);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.ReadKey();
          
        }
    }
}
