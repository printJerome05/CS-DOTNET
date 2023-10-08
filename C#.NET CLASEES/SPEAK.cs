using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_CLASEES
{
    internal class SPEAK
    {
        public void HELLO(string name)
        {
            Console.WriteLine("Hello "+ name);
        }
        public int ADD(int a , int b)
        {
            return a + b;
        }
        public int minusAll(params int[] nums)
        {
            int result = 0;
            foreach(int num in nums)
            {
                result -= num;
            }
            return result;

        }
    }
}
