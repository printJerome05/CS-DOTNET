using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_OVERLOAD_CONSTRUCTORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////OVERLOADING CONSTRUCTOR////////////////////////////////
            // technique to create multiple constructor with different set of parameters
            // each constructor should ha a unique paramter wiht each other
            pizza pz = new pizza("pizza1");
            pizza pz1 = new pizza("pizza2","red sauce", "pineaaple", "mozarella");
            pizza pz2 = new pizza("pizza3","greensauce");
            pizza pz3 = new pizza("pizza4","black sauce", "mushrooms");

            pz.reciept();
            pz1.reciept();
            pz2.reciept();
            pz3.reciept();

            pizza.complete();
            Console.ReadKey();
        }
    }

    class pizza
    {
        // it dont have a modifier like public so it will only be accesible in this class like a static
        string name;
        string sauce;
        string toppings;
        string cheese;


        public pizza(string name)
        {
            this.name = name;
           
        }

        public pizza(string name, string sauce)
        {
            this.name = name;
            this.sauce = sauce;
          
        }

        public pizza(string name, string sauce, string toppings)
        {
            this.name = name;
            this.sauce = sauce;
            this.toppings = toppings;
           
        }





        public pizza(string name, string sauce, string toppings, string cheese)
        {
            this.name = name;
            this.sauce = sauce;
            this.toppings = toppings;   
            this.cheese = cheese;
        }

        public void reciept()
        {
            Console.WriteLine($"Your order is {name} {sauce} {toppings} {cheese}");
        }
        public static void complete()
        {
            Console.WriteLine("Order Complete");
        }

    }
}
