using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_CLASEES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////CLASSES///////////////////////////////////////
            // Class = a bundle of related codes
            // this can be a blueprint to create objects (OOP)
            // can do it in this class or in another seperate file
            // method need to be a public to access it here
            // syntax for using method in other class
            // classname.function name = if it is in the same file
            greet.say();

            //if you want to acces different file class you need to instantiate like this
            // Classname newclassname = new Classname();
            SPEAK sk = new SPEAK();

            sk.HELLO("Jerome");

            int sum = sk.ADD(2, 3);
            Console.WriteLine(sum);

            int sums = sk.minusAll(2,2);
            Console.WriteLine(sums);

            // if class is in the other class file - the class file is a static class
            // to access it use classname.methodname
            STATIC.saySomething();

            
            
           

            Console.ReadKey();
        }
    }

    class greet
    {
        public static void say()
        {
            Console.WriteLine("HELLO");
        }
    }
}
