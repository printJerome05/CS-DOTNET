using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_GUESSING_NUMBER
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Random rnd = new Random();
            bool isAlive = true;
            int guess = 0;
            int guesses = 0;
            int min = 1;
            int max = 100;
            
            
            while(isAlive)
            {
                guess = 0;
                guesses = 0;
                int ran = rnd.Next(min, max + 1);
                string answer = "";


                while (guess != ran)
                {
                    Console.WriteLine("Enter a number between 1 and 100");
                    Console.Write("Number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess > ran)
                    {
                        Console.WriteLine( guess + " Number is higher");
                    }else if (guess < ran)
                    {
                        Console.WriteLine(guess + " Number is lower");
                    }
                    guesses++;   
                }
                Console.WriteLine("number of guess: " + guesses);
                Console.WriteLine("You got it: " + guess);

                Console.WriteLine("Would you like to guess again?");
                Console.WriteLine("Y/N");
                answer = Console.ReadLine();

                if(answer.ToUpper() == "Y")
                {
                    isAlive = true;
                }
                else
                {
                    isAlive = false;
                }

               


            }
           

            Console.ReadKey();
        }
    }
}
