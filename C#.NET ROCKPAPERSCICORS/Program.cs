using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.NET_ROCKPAPERSCICORS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////ROCK PAPER SCICORS GAME/////////////////////////////////
            
            Random rnd = new Random();
            bool isAlive = true;

            int live = 5;

            while (isAlive)
            {
                string enemystate = "";
                int enemy = rnd.Next(1,4);
                string player = "";
                
                if(enemy == 1)
                {
                    enemystate = "PAPER";
                }
                else if (enemy == 2)
                {
                    enemystate = "ROCK";
                }
                else if(enemy == 3)
                {
                    enemystate = "SCISSORS";
                }

                while (player.ToUpper() != "ROCK" && player.ToUpper() != "PAPER" && player.ToUpper() != "SCISSORS") 
                {
                    Console.WriteLine("LIVES LEFT: " + live);
                    Console.Write("ROCK, PAPER, SCISSORS: ");
                    player = Console.ReadLine();    
                }

                Console.WriteLine("YOU: "+ player);
                Console.WriteLine("ENEMY: "+enemystate);

                switch (player)
                {
                    case "ROCK":
                        if (enemystate == "ROCK")
                        {
                            Console.WriteLine("draw");
                        }
                        else if(enemystate == "PAPER")
                        {
                            live--;
                            Console.WriteLine("YOU LOSE");
                        }else if(enemystate == "SCISSORS")
                        {
                            Console.WriteLine("YOU WON");
                        }
                        break;
                    case "PAPER":
                        if (enemystate == "ROCK")
                        {
                            Console.WriteLine("YOU WON");
                        }
                        else if (enemystate == "PAPER")
                        {
                            Console.WriteLine("draw");
                        }
                        else if (enemystate == "SCISSORS")
                        {
                            Console.WriteLine("YOU LOSE");
                            live--;
                        }
                        break;
                    case "SCISSORS":
                        if (enemystate == "ROCK")
                        {
                            Console.WriteLine("YOU LOST");
                            live--;
                        }
                        else if (enemystate == "PAPER")
                        {
                            Console.WriteLine("YOU WON");
                        }
                        else if (enemystate == "SCISSORS")
                        {
                            Console.WriteLine("DRAW");
                        }
                        break;

                  }
                if(live == 0)
                {
                    Console.WriteLine("gameover");
                    Console.WriteLine("DO YOU WANT TO CONTINUE Y/N");
                    string answer = Console.ReadLine();
                    if(answer.ToUpper() == "Y")
                    {
                        live = 5;
                    }
                    else
                    {
                        isAlive = false;
                    }


                }


            
               
            }
            Console.WriteLine("THANK YOU FOR GAMMING");

            Console.ReadKey();

        }
    }
}
