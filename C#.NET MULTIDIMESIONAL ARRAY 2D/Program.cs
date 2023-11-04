using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_MULTIDIMESIONAL_ARRAY_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MULTI DIMMESIONAL ARRAY
                                
            string[,] cars = { {"HONDA1","HONDA2","HONDA3"},
                               {"TOYOTA1","TOYOTA2","TOYOTA3"},
                               {"LAMBO1","LAMBO2","LAMBO3"}
                             };
            // THE LENGTH OF THE FIRST ARRAY SHOULD BE THE LENGHT OF ALL SUCCEDING ARRAY 

            // CHANGE VALUE

            cars[0, 1] = "HONDA5";
            cars[2,0 ] = "HONDA1";


            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // TO PRINT IT LIKE A TABLE
            // getlength use for 2d array
           for(int i = 0; i < cars.GetLength(0); i++){

                for(int j = 0; j < cars.GetLength(1); j++)
                {
                    Console.Write(cars[i, j]);
                }
                Console.WriteLine();
            }

   

            

            Console.ReadKey();
        }
    }
}
