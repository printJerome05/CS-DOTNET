using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_CONSTRUCTOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////CONSTRUCTOR//////////////////////////////////////////
            // A SPECIAL METHOD IN CLASS
            // SAME NAME AS THE CLASS NAME

            string name = "Mara";
            int id = 2;
            int age = 22;

            student s2 = new student(id,name,age);
            student s1 = new student(1,"Jerome",22); // need to have a value in the () is it is a constructor
            s1.info();
            s2.info();


            Console.ReadKey();
        }
    }
    class student
    {
        public int id;
        public string name;
        public int age;
        
        public student(int id, string name, int age)
        {
            this.id = id; // need to do this to pass data in other method in this class
            this.name = name;
            this.age = age;
        }

        public void info()
        {
            Console.WriteLine($"Hi i am {name} my id is {id} i am {age} years old");
        }
    }
}
