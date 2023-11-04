using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_ABSTRACT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////ABSTRACT//////////////////////////////////////
            // IT IS A MODIFIER THAT INDICATES MISSING COMPONENT OF MISSING IMPLEMENTATIONS
            // BEST USE FOR CLASS TO NOT INSTANTIATE IT
            // you can get its function
            Person.greet();

            // but you cannot do bellow
            //------Person p1 = new Person();   

            Console.ReadKey();

        }
    }
    //IF YOU PUT ABSTRACT IN THIS CLASS NAME YOU CANNOT ISNTANTIATE IT
    abstract class Person
    {
        public string name;

        public static void greet()
        {
            Console.WriteLine("hello ");
        }
    }
}
