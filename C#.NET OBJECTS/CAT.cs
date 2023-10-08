using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_OBJECTS
{
    internal class CAT
    {
        public string name;
        public string description;

        public void catName()
        {
            Console.WriteLine("Cat name is "+name);
        }
        public void catDescription()
        {
            Console.WriteLine("it is a "+ description);
        }
    }
}
