using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////ARRAY//////////////////////////////////////////////////
            // array stores multiple data it is fixed size
            
            string[] names = {"jerome","marco","mara"};
            int[] numbers = {1,2,3,4,5,6,7 };

            //printing array
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            int[] numbers1 = new int[4];  // need to define a int to have a range
            numbers1[0] = 1;
            numbers1[1] = 4;
            numbers1[2] = 5;
            numbers1[3] = 10;

            for (int i = 0; i < numbers1.Length;i++)
            {
                Console.WriteLine(numbers1[i]);
            }




            Console.ReadKey();
        }
    }
}
