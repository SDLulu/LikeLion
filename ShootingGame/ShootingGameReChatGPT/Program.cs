using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ShootingGameReChatGPT
{
    public class Bullet
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsActive { get; set; } = false;
    }

    public class BulletManager
    {
        private List<Bullet> bullets = new List<Bullet>();
        private string bulletSprite = "->";

        public BulletManager(int capacity)
        {
            for (int i = 0; i < capacity; i++)
                bullets.Add(new Bullet());
        }

        public void Fire(int startX, int startY)
        {
            foreach (var bullet in bullets)
            {
                if (!bullet.IsActive)
                {
                    bullet.X = startX;
                    bullet.Y = startY;
                    bullet.IsActive = true;
                    break;
                }
            }
        }

        public void Update()
        {
            foreach (var bullet in bullets)
            {
                if (bullet.IsActive)
                {
                    Console.SetCursorPosition(bullet.X, bullet.Y);
                    Console.Write(bulletSprite);
                    bullet.X++;
                    if (bullet.X > 78) bullet.IsActive = false;
                }
            }
        }
    }

    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch();

        public int X { get; private set; } = 0;
        public int Y { get; private set; } = 12;
        private BulletManager bulletManager = new BulletManager(20);
        public int Score { get; private set; } = 100;
        public int ItemCount { get; private set; } = 0;

        public void Update()
        {
            HandleInput();
            Draw();
            bulletManager.Update();
        }

        private void HandleInput()
        {
            if (!Console.KeyAvailable) return;
            int key = _getch();
            if (key == 0 || key == 224) key = _getch();

            switch (key)
            {
                case 72: Y = Math.Max(1, Y - 1); break;
                case 75: X = Math.Max(0, X - 1); break;
                case 77: X = Math.Min(75, X + 1); break;
                case 80: Y = Math.Min(21, Y + 1); break;
                case 32:
                    bulletManager.Fire(X + 5, Y + 1);
                    if (ItemCount >= 1) bulletManager.Fire(X + 5, Y);
                    if (ItemCount >= 2) bulletManager.Fire(X + 5, Y + 2);
                    break;
            }
        }

        private void Draw()
        {
            string[] playerSprite = { "->", ">>>", "->" };
            for (int i = 0; i < playerSprite.Length; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.WriteLine(playerSprite[i]);
            }
        }

        public void CollectItem()
        {
            if (ItemCount < 2) ItemCount++;
        }
    }

    public class Enemy
    {
        public int X { get; private set; } = 75;
        public int Y { get; private set; } = 12;
        private static Random rand = new Random();

        public void Move()
        {
            X--;
            if (X < 2)
            {
                X = 75;
                Y = rand.Next(2, 22);
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write("<-0->");
        }
    }

    public class Item
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsActive { get; set; } = false;

        public void Draw()
        {
            if (IsActive)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write("Item★");
            }
        }
    }

    public class Game
    {
        private Player player = new Player();
        private Enemy enemy = new Enemy();
        private Item item = new Item();
        private int frameTime = Environment.TickCount;

        public void Run()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            while (true)
            {
                if (frameTime + 50 < Environment.TickCount)
                {
                    frameTime = Environment.TickCount;
                    Console.Clear();
                    player.Update();
                    enemy.Move();
                    enemy.Draw();
                    item.Draw();
                    CheckCollisions();
                }
            }
        }

        private void CheckCollisions()
        {
            if (player.X >= enemy.X - 1 && player.X <= enemy.X + 1 && player.Y == enemy.Y)
            {
                item.IsActive = true;
                item.X = enemy.X;
                item.Y = enemy.Y;
                player.Score += 100;
                enemy.Move();
            }

            if (player.X >= item.X - 1 && player.X <= item.X + 1 && player.Y == item.Y && item.IsActive)
            {
                item.IsActive = false;
                player.CollectItem();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Run();
        }
    }
}
