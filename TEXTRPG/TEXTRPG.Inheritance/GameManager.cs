using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEXTRPG.Inheritance;

namespace TEXTRPG_Inheritance
{ 
    public class GameManager
    {
        Player player;
        Field field;
        int input;
        //게임흐름

        //직업선택
        //플레이어객체생성
        //직업에따른플레이어객체필드값지정 
        //

        public void start()
        {
            input = 0;


            Console.WriteLine("직업을 선택하세요.(1.기사 2.마법사 3.도적");
            input = int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    player = new Player("기사", 100, 10);
                    break;
                case 2:
                    player = new Player("법사", 50, 20);
                    break;
                case 3:
                    player = new Player("도적", 75, 15);
                    break;
                default:
                    Console.WriteLine("오류");
                    break;
            }
        }
        public void progress()
        {
            while(true)
            {
                Console.Clear();
                player.ShowStatus();
                Console.WriteLine("1.사냥터 2.전단계로");
                select();


                if (input == 1)
                {
                    while (true)
                    {
                        Console.Clear();
                        player.ShowStatus();
                        Console.WriteLine("사냥터를선택하세요");
                        Console.WriteLine("1.초보맵");
                        Console.WriteLine("2.중수맵");
                        Console.WriteLine("3.고수맵");
                        Console.WriteLine("4.전단계로");
                        select();
                        if (input == 1)
                            field = new Field("초보맵");
                        if (input == 2)
                            field = new Field("중수맵");
                        if (input == 3)
                            field = new Field("고수맵");
                        if (input == 4)
                            break;
                        field.createMonster();

                        while (true)
                        {
                            Console.Clear();
                            player.ShowStatus();
                            field.monster.showStatus();
                            Console.WriteLine("행동");
                            Console.WriteLine("1.공격 2.전단계로");
                            select();
                            if (input == 1)
                            {
                                player.hp = player.hp - field.monster.attack;
                                field.monster.hp = field.monster.hp - player.attack;
                                if (player.hp <= 0)
                                {
                                    Console.Clear();
                                    player.ShowStatus();
                                    field.monster.showStatus();
                                    Console.WriteLine("주금(1.확인)");
                                    select();
                                    player.hp = 100;
                                    break;
                                }
                                if (field.monster.hp <= 0)
                                {
                                    Console.Clear();
                                    player.ShowStatus();
                                    field.monster.showStatus();
                                    Console.WriteLine("잡음(1.확인)");
                                    select();
                                    break;
                                }

                                continue;
                            }
                            if (input == 2)
                                break;
                        }
                    }
                }
                if (input == 2)
                {
                    break;
                }
       
            }
       
        }

        public void select() { input = int.Parse(Console.ReadLine()); }
        
    }
}
