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

            while (F1.IsAlive() == true && F2.IsAlive() == true)
            {
                F2.Hurt();

                Console.WriteLine(F1.name + " throws a punch!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hit!");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine(F2.name + " has " + F2.GetHp() + " HP left!");
                System.Threading.Thread.Sleep(1000);

                if(F2.IsAlive() == false)
                {
                    break;
                }

                F1.Attack();
                F1.Hurt();
                     
                Console.WriteLine(F2.name + " throws a punch!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Hit!"); //
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine(F1.name + " has " + F1.GetHp() +  " HP left!");
                System.Threading.Thread.Sleep(1000);

                //gör en if-loop så HP inte kan bli under 0. typ if (hp < 0) "hp = 0;"

            }

            Console.WriteLine("Wow! Great Match!");

            if (F1.IsAlive() == false)
            {

                Console.WriteLine(F2.name + " won! They are the champion!");

            }
            else if (F2.IsAlive() == false)
            {

                Console.WriteLine(F1.name + " won! They are the champion!");

            }

            Console.ReadLine();

        }
    }
}
