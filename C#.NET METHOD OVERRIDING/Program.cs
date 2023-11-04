using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_METHOD_OVERRIDING
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////METHOD OVERRIDING///////////////////////////////////////////
            // provides a new version of method inherited from a parent class inherited method must be: abstract
            // , virtual or already overriden Used with ToString(), polymorphism

            People p1 = new People();
            Male m1 = new Male();
            Female f1 = new Female();
            Unknown uk = new Unknown();

            p1.Speak(); // parrent class
            m1.Speak();
            f1.Speak();
            uk.Speak();


            Console.ReadKey();
        }
    }

    class People
    {
        public virtual void Speak() // using public virtual you cac override the method in another class
                                    // if you use public abstract you should abstract the class too
                                    // need to be inherited to access overriding methods
        {
            Console.WriteLine("Hello World");
        }
    }

    class Male : People
    {
        public override void Speak() // if you want to override the method use public override
        {
            Console.WriteLine("Hi am a male");
        }
    }

    class Female : People
    {
        public override void Speak() // if you want to override the method use public override
        {
            Console.WriteLine("Hi am a female");
        }
    }

    class Unknown : People
    {

    }
    
    class Boy
    {
      
    }
}
