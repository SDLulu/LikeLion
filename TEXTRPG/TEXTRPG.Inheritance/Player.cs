using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG.Inheritance
{
    public class Player
    {
        public string name;
        public int hp;
        public int attack;

        public Player(string name, int hp, int attack)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
        }

        public void ShowStatus()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("직업 이름 : " + name);
            Console.WriteLine("체력 : " + hp + "\t공격력 :  " +  attack);
            Console.WriteLine("=========================");
        }
    }
}
