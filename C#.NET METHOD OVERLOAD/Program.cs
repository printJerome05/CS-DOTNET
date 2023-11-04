using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_METHOD_OVERLOAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////METHOD OVERLOADING//////////////////////////////////////
            // methods share the same name, but wit different parameters
            Console.WriteLine(add(1,2));
            Console.WriteLine(add(1, 2, 3));

            greet("Jerome", "Marco", 22);
            greet("Mara", "Oruga");

            Console.ReadKey();
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int add(int a, int b, int c)// just add another parameter so it can be a overload method
        {
            return a + b + c;
        }

        static void greet(string fname, string lname)
        {
            Console.WriteLine("I am "+ fname+" "+lname);
        }

        static void greet(string fname, string lname, int age)
        {
            Console.WriteLine("I am " + fname + " " + lname +" "+age+" years old");
        }
    }
}
