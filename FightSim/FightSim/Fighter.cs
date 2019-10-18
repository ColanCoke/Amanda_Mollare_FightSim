using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {

        int hp = 50;

        public string name;

        Random genDmg = new Random();

        public int Attack()
        {
            return genDmg.Next(5, 15);
        }

        public void Hurt()
        {

            hp = hp - Attack();

            if(hp < 0)
            {
                hp = 0;
            }

        }

        public bool IsAlive()
        {

            if(hp <= 0)
            {
                return false;
            }

            return true;
        }

        public int GetHp()
        {
            return hp;
        }

    }
}
