using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_IFELSE_STATEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////IF ELSE///////////////////////////////////////
            Console.WriteLine("ENTER age");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 18)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("teenage");
            }

            string name = "Marco";


            if(name == "Jerome")
            {
                Console.WriteLine("Access Granted");
            }
            else if (name == "Marco")
            {
                Console.WriteLine("Admin Logged In");
            }
            else
            {
                Console.WriteLine("Access Denied");
            }

            Console.ReadKey();
               
        }
    }
}
