using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_PARAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////PARAMS////////////////////////////////////////
            // a method parameter that takes variable number of arguments. it should be a single dimensional array
            // best use for params is for overlaoding
            int total = item(1,2,3,4,5,6,7,8);
            Console.WriteLine(total);

            greet("Jerome","Marco","Mara");
            greet("Secret");

            Console.ReadKey();
        }
        static int item(params int[] sums) // params is added to the parameter () it should be an array. singlle type only 
                                          // if it is an int it should be an integer value.
        {
            int total = 0;
            foreach (int sum in sums) { // need to foreach if it is array 
                total += sum;
            }
            return total;
        }

        static void greet(params string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine($"hello {name}");
            }
        }
    }
}
