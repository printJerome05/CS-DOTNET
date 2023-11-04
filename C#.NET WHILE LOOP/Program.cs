using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_WHILE_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////WHILE LOOP////////////////////////////////////////

            String name = "";

            while(name == "") // if its true it will run again and again
            {
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
            }
            Console.WriteLine("Name is:"+ name);

            int number2 = 12;
            while (number2 >= 20) // variable not need to be empty and null
            {
                Console.WriteLine("hello");
                
            }

            /*
             this is an infinite loop commented 
                int number1 = 1;
                while (number1 == 1)
                {
                    Console.WriteLine("LOOPING");
                }
            */ 

            Console.ReadKey();
        }
    }
}
