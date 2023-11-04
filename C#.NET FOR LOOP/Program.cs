using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_FOR_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////FOR LOOP//////////////////////////////////////////////////////////
            // for = repeat the code finite amount of times. While loop can go inifinite amount for loop can go a finite or a limited ammount

            int a = 10;
            for (int i = 0; i <= a; i++) // printing 0 to 10
            {
                Console.WriteLine(i);
            }
            

            
            for (int b = 10; b > 0; b--) // countdown 10 to 1
            { 
                Console.WriteLine(b);
            }
            Console.WriteLine("HelloWorld");



            Console.ReadKey();
        }
    }
}
