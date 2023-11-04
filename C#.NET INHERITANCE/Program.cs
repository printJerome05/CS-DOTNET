using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_.NET_INHERITANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////INHERITANCE//////////////////////////////////////////////////////////////
            // 1 OR MORE CLASSES RECIEVING FILEDS METHODS ETC FROM ITS PARENTS CLASS
            // syntax of inheritance classname : parentclass
            // can it in diferrent class files

            //same files
            biycles b1 = new biycles();
            car c1 = new car();
            boat b2 = new boat();
            truck t1 = new truck();

            b1.wheels = 2;
            b1.description();
            c1.wheels = 4;
            c1.description();
            b2.wheels = 0;
            b2.description();
            t1.wheels = 6;
            t1.description();
            vehicle.Start();

            //different class files inheritance
            Student1 st1 = new Student1();
            Student2 st2 = new Student2();
            Student3 st3 = new Student3();

            st1.grade = 1;
            Console.WriteLine(st1.gender);
            School.Greet(st1.name); // can pass variables into parameters
            st1.sayGrade();

            st2.grade = 2;
            Console.WriteLine(st2.gender);
            School.Greet(st2.name);
            st2.sayGrade();

            st3.grade = 3;
            Console.WriteLine(st3.gender);
            School.Greet(st3.name);
            st3.sayGrade();

          




            Console.ReadLine();
        }
    }

    
    class vehicle // this is the parent class
    {
        public int wheels = 0;

        public static void Start()
        {
            Console.WriteLine("THIS VEHICLE IS MOVING");
        }
        public void description()
        {
            Console.WriteLine($"I have {wheels}");
        }
    }

    // CHILD CLASS 
    class biycles : vehicle {
        public int speed = 20;
        
    }

    class car : vehicle
    {
        public int speed = 80;

    }
    class boat : vehicle
    {
        public int speed = 70;

    }
    class truck : vehicle
    {
        public int speed = 50;

    }




}
