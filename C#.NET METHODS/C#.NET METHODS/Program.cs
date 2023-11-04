using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_METHODS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////METHOD///////////////////////////////////////
            // perform a action of code, whenever it is called
            // benifit ot this method is that we dont need to write multiple times 

            string name = "Jerome";
            int age = 22;


            Greet();
            me(name, age);// need to have a value if it have a parameter

            
            Console.ReadKey();

        }
        static void Greet()
        {
            Console.WriteLine("Hello world");
        }

        static void me(string name, int age)// (inside this is a parameter) which we will pass inside the method to use it
        {
            Console.WriteLine("My name is "+name+", I am "+age);
        }
    }
}
