using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {

        int hp;

        public string name;

        Random genDmg;

        public int Attack()
        {
            return genDmg.Next(1, 10);
        }

        public void Hurt(int amount)
        {

            hp = hp - amount;

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
