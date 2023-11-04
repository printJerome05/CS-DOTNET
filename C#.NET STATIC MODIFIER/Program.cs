using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_STATIC_MODIFIER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////STATIC///////////////////////////////////////
            // static = a modifier for class varibles and methods
            // to declare a static member, which belongs to the class itself rather than to any objects
            // anything the declare a static belongs only to the class and can be access in anyobjects

            race r1 = new race("RACER1");
            race r2 = new race("RACER2");

            Console.WriteLine(race.numberofRacer); // can access directly from class when it i sstatic
            //no need to instantiate if it is a static 
            race.Start();

            


            Console.ReadKey();
        }
    }

   class race
    {
        public string name;
        public static int numberofRacer;

        public race(string name)
        {
            this.name = name;
            numberofRacer++;
        }

        public static void Start()
        {
            Console.WriteLine("Race has started");
        }

    }
}
