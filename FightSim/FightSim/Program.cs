using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Fight Simulator!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Choose name of Fighter 1:");

            Fighter F1 = new Fighter();
            Fighter F2 = new Fighter();

            F1.name = Console.ReadLine();

            Console.WriteLine(F1.name + " is good. Now choose name of Fighter 2:");

            F2.name = Console.ReadLine();

            Console.WriteLine(F2.name + " is very good name. Now...");

            Console.WriteLine("YES! FIGHT.... START!!!!!!!!!!");

            Console.ReadLine();

            while (F1.IsAlive() == true && F2.IsAlive() == true)
            {

                Console.WriteLine( " throws a punch!");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Hit! " + " did: " +  " amounts of damage!"); //berättar för spelaren hur mycket damage hen gjorde för rundan
                System.Threading.Thread.Sleep(1500);

                Console.WriteLine( " has " +  " HP left!");
                System.Threading.Thread.Sleep(1500);

                Console.WriteLine(" throws a punch!");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Hit! " + " did: " + " amounts of damage!"); //berättar för spelaren hur mycket damage hen gjorde för rundan
                System.Threading.Thread.Sleep(1500);

                Console.WriteLine( " has " +  " HP left!");
                System.Threading.Thread.Sleep(1500);

                //gör en if-loop så HP inte kan bli under 0. typ if (hp < 0) "hp = 0;"

            }

        }
    }
}
