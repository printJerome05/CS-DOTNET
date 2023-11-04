using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_CALCULATOR_PROGRAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////CALCULATOR PROGRAM//////////////////////////////
            bool answer = true;
            double num1 = 0;
            double num2 = 0;
            string operators = "";
            double result = 0;
           

            Console.WriteLine("-----------------------------");
            Console.WriteLine("----------CALCULATOR---------");
            Console.WriteLine("-----------------------------");
            while (answer)
            {
                string calagain = "";
                Console.Write("Enter number1: ");
                num1 = Convert.ToDouble(Console.ReadLine());    
                Console.Write("Enter number2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("+, -, /, *");
                Console.Write("Select Operator: ");
                operators = Convert.ToString(Console.ReadLine());
           

                switch (operators)
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Answer {num1} + {num2}: "+ result);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(" Do you want to calculate again? Y/N");
                        calagain = Console.ReadLine();
                        if (calagain.ToUpper() == "Y")
                        {
                            answer = true;
                            
                        }
                        else
                        {
                            answer = false;
                        }
                        
                        
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Answer {num1} - {num2}: " + result);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(" Do you want to calculate again? Y/N");
                        calagain = Console.ReadLine();
                        if (calagain.ToUpper() == "Y")
                        {
                            answer = true;

                        }
                        else
                        {
                            answer = false;
                        }

                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Answer {num1} * {num2}: " + result);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(" Do you want to calculate again? Y/N");
                        calagain = Console.ReadLine();
                        if (calagain.ToUpper() == "Y")
                        {
                            answer = true;

                        }
                        else
                        {
                            answer = false;
                        }

                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Answer {num1} / {num2}: " + result);
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine(" Do you want to calculate again? Y/N");
                        calagain = Console.ReadLine();
                        if (calagain.ToUpper() == "Y")
                        {
                            answer = true;

                        }
                        else
                        {
                            answer = false;
                        }

                        break;

                }
                

            }
            Console.WriteLine("THANK YOU FOR USING CALCULATOR");
            Console.ReadKey();
        }
         
    }
}
