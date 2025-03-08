using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGameRe
{
    public class Player
    {
        public int x;
        public int y;
        public bool isSlotTop;
        public bool isSlotMid;
        public bool isSlotBottom;
        public bool isExist;
        public Player()
        {
            string[] image = new string[]
            {
                "->",
                ">>>",
                "->"
            };
        }

    }
    public class Bullet
    {
        public int x;
        public int y;
        public bool isExist;
        public string image = "->";
    }
    public class Enemy
    {
        public int x;
        public int y;
        public bool isExist;
    }
    public class Item
    {
        public int x;
        public int y;
        public bool isExist;

    }
    public class ScoreBoard
    {
        public int x;
        public int y;
        public bool isExist;
    }

    public class GameControl
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();  //c언어 함수 가져옴
        Player player = new Player();
        
        public enum Key
        {
            KeyUp = 72,
            KeyLeft = 75,
            KeyRigth = 77,
            KeyDown = 80,
            KeySpace = 32

        }
        public void ScreenSetting()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
        }
        public void KeyControl()
        {
            int pressKey;  //정수형 변수선언 키값 받을거임 

            if (Console.KeyAvailable) //키가 눌렸을때 true
            {
                pressKey = _getch(); //아스키값 왼쪽 오른쪽
                if (pressKey == 0 || pressKey == 224) // 화살표 키 또는 특수 키 감지
                {
                    pressKey = _getch(); // 실제 키 값 읽기
                }

                switch (pressKey)
                {
                    case (int)Key.KeyUp :  //위쪽방향 아스키코드                    
                        player.y--;
                        if (player.y < 1);
                        player.y = 1;
                        break;
                    case (int)Key.KeyLeft:
                        //왼쪽 화살표키
                        player.x--;
                        if (player.x < 0)
                            player.x = 0;
                        break;
                    case (int)Key.KeyRigth:
                        //오른쪽
                        player.x++;
                        if (player.x  > 75)
                            player.x  = 75;
                        break;
                    case (int)Key.KeyDown:
                        //아래
                        player.y++;
                        if (player.y > 21)
                            player.y = 21;
                        break;
                    case (int)Key.KeySpace:
                        //스페이스바 총알 발사
                        Fire();
/*                        for (int i = 0; i < 20; i++)
                        {
                            //미사일이 false 발사가능
                            if (playerBullet[i].fire == false)
                            {
                                playerBullet[i].fire = true;
                                //플레이어 앞에서 미사일 쏘기 + 5
                                playerBullet[i].x = playerX + 5;
                                playerBullet[i].y = playerY + 1;
                                //한발씩 쏘겠다.
                                break;
                            }
                        }*/
                }


            }


        }
        public void Fire()
        {
            Bullet bullet = new Bullet();
            bullet.x = player.x;
            bullet.y = player.y;
            bullet.
        }
        public void SpwanEnemy()
        {

        }
        public void DrawObject()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GameControl gamecontrol = new GameControl();
            Player player = new Player();
            Enemy enemy = new Enemy();
            //클래스 참조

            gamecontrol.ScreenSetting();

            //유니티처럼 속도 프레임속도
            int dwTime = Environment.TickCount;  // 1/1000 초가 흐른다.

            while (true) //무한반복
            {
                //0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    //현재시간 세팅
                    dwTime = Environment.TickCount;
                    Console.Clear();

                    //플레이어
                    player.GameMain();

                    //총알

                    if (player.itemCount == 0)
                    {
                        player.BulletDraw();
                    }
                    else if (player.itemCount == 1)
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                    }
                    else
                    {
                        player.BulletDraw();
                        player.BulletDraw2();
                        player.BulletDraw3();
                    }
                    enemy.EnmeyMove();//적이동
                    enemy.EnemyDraw();//적그리기

                    //충돌처리
                    player.ClashEnemyAndBullet(enemy);
                }
            }
        }
    }
}
