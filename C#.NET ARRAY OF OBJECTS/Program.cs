using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_ARRAY_OF_OBJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////ARRAY OF OBJECTS////////////////////////////////////////////////////////////
            // COLLECTION OF OBJECTS 
            // the number 3 in the [3] is the size of the array

            bicycle[] bikes = new bicycle[3];

            bicycle b1 = new bicycle("BIKE1");
            bicycle b2 = new bicycle("BIKE2");
            bicycle b3 = new bicycle("BIKE3");

            // to set value need to assign it
            bikes[0] = b1;
            bikes[1] = b2;
            bikes[2] = b3;

            // to print for each loop
            foreach(bicycle bike in bikes)
            {
                Console.WriteLine(bike.model);
            }

            // for loop to print object array
            for (int i = 0; i < bikes.Length; i++)
            {
                Console.WriteLine(bikes[i].model);
            }




            Console.ReadKey();
        }
    }

    class bicycle
    {
        public string model;

        public bicycle(string model)
        {
            this.model = model;
        }
    }
}
