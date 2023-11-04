using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_NESTED_LOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////NESTED LOOP////////////////////////////////////////////////////////
            // A LOOP WITHIN A LOOP

            // rectangle
            Console.WriteLine("How many rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Columns");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What symbol to use");
            string sym = Console.ReadLine();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
