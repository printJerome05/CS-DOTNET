using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_EXCEPTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////EXCEPTIONS///////////////////////////////////////////////
            // exeception = errors that occurs during execution
            // best use for exception is the try catch finally method

            // try = try some codes that is considered dangerously
            // catch = in this block error is handled here
            // finally = it will always run even it is succesfull or have an catch

            int a = 0;
            int b = 0;

            try {
                Console.Write("Enter number1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number2: ");
                b = Convert.ToInt32(Console.ReadLine());
                int result = a / b;
                Console.WriteLine("Answer: " + result);
            }
          
            catch (DivideByZeroException e) { // can do multiple exceptions to know what happened
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            { // the most basic execption handles all exception 
                Console.WriteLine(e.Message); // 
            }
            finally {
                Console.WriteLine("THANKYOU");
            }

            Console.ReadKey();

               


        }
    }
}
