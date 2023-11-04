using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_STRING_INTERPOLATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////STRING INTERPOLATION////////////////////////////////////////
            // allows to insert variables into a string literal
            // sytanx =  $""
            // if you want to add variable use {variable name}

            string fname = "Jerome";
            string lname = "Marco";
            int age = 22;

            Console.WriteLine($"Hi my name is {fname} {lname}");
            Console.WriteLine($"My age is {age,5} years old");// the 5 after the age means spaces can do - or a postive see results in start
            Console.WriteLine($"My age is {age,-5} years old");

            Console.ReadKey();


        }
    }
}
