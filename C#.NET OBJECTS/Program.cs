using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_OBJECTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////OBJECTS///////////////////////////////////////////
            // AN INSTANCE OF CLASS 
            // best use for doing OOP OR OBJECT
            // OBJECTS IS A COLLECTION OF FIELDS AND METHODS
            // CAN DO A SPERATE FILE OR IN THIS FILE 

            // instantiate first best practice for doing multiple objects
            human hn = new human();
            hn.name = "Jerome";
            hn.sleeping = 8;

            human hn1 = new human();
            hn1.name = "Marco";
            hn1.sleeping = 7;

            hn.say();
            hn.sleep();

            hn1.say();
            hn1.sleep();

            //from diferent class file
            CAT ct = new CAT();
            ct.name = "Mara";
            ct.description = "PolkaDOt";

            ct.catName();
            ct.catDescription();

            Console.ReadKey();
        }


    }
    class human {
        public string name;
        public int sleeping;

        public void say()
        {
            Console.WriteLine("Hi i am "+name);
        }
        public void sleep()
        {
            Console.WriteLine($"I am sleeping {sleeping} a day");
        }



    }


}
