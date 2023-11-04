using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_INHERITANCE
{
    internal class School
    {
        public int grade = 0;

        public static void Greet(string name)
        {
            
            Console.WriteLine($"I am {name}" );

        }
        public void sayGrade()
        {
            Console.WriteLine("I am grade "+ grade);
        }

    }
   
}
