using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEXTRPG.Inheritance
{
    public class Field
    {
        public Monster monster;
        public string name;

        public Field(string name)
        {
            this.name = name;
        }

        public void createMonster()
        {
            if(name == "초보맵")
                monster = new Monster("고블린",30, 3);
            else if(name == "중수맵")
                monster = new Monster("스켈레톤", 50, 5);
            else if(name == "고수맵")
                monster = new Monster("킹슬라임", 200, 3);
        }
        


    }
}
