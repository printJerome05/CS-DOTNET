using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_RETURN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////RETURN/////////////////////////////////////////////////
            // RETURNS A DATA BACK TO THE PLACE WHERE METHOD IS INVOKE
            int a = 22;
            int b = 42;
            string name = "jerome";
            
            Console.WriteLine(add(12,23));

            Console.WriteLine(add(a,b));

            Console.WriteLine(greet("Jerome"));

            greet1(name);
            greet1("Mara");

            Console.ReadLine();
        }
        static int add(int a, int b) // need to change the void into what type of variable is in the return
        {
            return a + b;
        }
        
        static string greet(string name) // if the return is a string then return a then it is static string
        {
            string say = "goodday" + name;
            return say;
        }

        static void greet1(string name) // if it is a string then you can go for static void and console.writeline inside
        {
            Console.WriteLine("Hello "+ name);
        }
    }
}
