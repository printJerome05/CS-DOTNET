using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////SWITCH STATEMENT/////////////////////////////////////
            // simplier wait if your using to many else if statement

            int number = 2;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Number 1");
                    break;
                case 2:
                    Console.WriteLine("Number 2");
                    break;
                default:
                    Console.WriteLine("Erorr");
                    break;
            }

            // for string user input
            Console.WriteLine("ENTER NAME");
            string name = Console.ReadLine();

            switch (name.ToUpper())
            {
                case "JEROME":
                    Console.WriteLine("Welcome");
                    break;
                case "MARCO":
                    Console.WriteLine("Welcome Admin");
                    break;
                default:
                    Console.WriteLine("No user FOund");
                    break;
            }

            Console.ReadKey();
        }
    }
}
