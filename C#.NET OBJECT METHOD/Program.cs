using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_OBJECT_METHOD
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            
            Names names1 = new Names("Jerome" , 22);

            Names names2 = copy(names1);

            Console.WriteLine(names2.name+ names2.age);
            names1.greet();

            Names names3 = changeAge(names1, 15);
            Console.WriteLine(names3.name+ names3.age);
            names3.greet();

           
            

            Console.ReadKey();
        }
        // just returing the value and copying any object
        public static Names copy(Names name)
        {
            return new Names(name.name, name.age);
        }

        // need to be static can add and change paramenter in objects
        public static Names changeAge(Names name, int age)
        {
            name.age = age;
            return new Names(name.name, age);
        }
    }

    class Names
    {
        public string name;
        public int age;
        public Names(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void greet()
        {
            Console.WriteLine($"Hi i am {name} my age is {age} years old");
        }
    }
}
