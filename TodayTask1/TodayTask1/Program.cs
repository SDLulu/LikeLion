using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TodayTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //로딩바 시작화면
            //게임스토리1
            //비주얼노벨만들어보기

            //제목
            Console.Title = "C# Console Text Game";

            //로딩
            Console.WriteLine("LOADING...");
            Console.WriteLine("■□□□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■□□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■□□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■□□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■□□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■■□□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■■■□□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■■■■□□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■■■■■□");
            Thread.Sleep(100);
            Console.Clear();
            Console.WriteLine("LOADING...");
            Console.WriteLine("■■■■■■■■■■");
            Thread.Sleep(100);
            Console.Clear();


            //타이틀
            string input;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("■■■■■  ■■■■■");
            Console.WriteLine("■      ■       ");
            Console.WriteLine("■  ■■  ■  ■■  ");
            Console.WriteLine("■   ■  ■   ■  ");
            Console.WriteLine("■■■■■  ■■■■■  ");

            Console.WriteLine("   _     _   ");
            Console.WriteLine("  (c).-.(c)  ");
            Console.WriteLine("   / ._. \\   ");
            Console.WriteLine(" __\\( Y )/__ ");
            Console.WriteLine("(_.-/'-'\\-._)");
            Console.WriteLine("   || O ||   ");
            Console.WriteLine(" _.' `-' '._ ");
            Console.WriteLine("(.-./`-'\\.-.)");
            Console.WriteLine(" `-'     `-' ");

            Console.WriteLine(" New Game");
            Console.WriteLine(" Continue");
            Console.WriteLine(" Quit");
            input = Console.ReadLine();

            Console.Clear();

            //처음부터시작
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("당신이 좋아하는 동물은? ");
            string input4 = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("당신의 나이는? ");
            string input1 = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("당신이 최근에 갔다왔던 나라는? ");
            string input2 = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("당신이 자주쓰는 도구는? ");
            string input3 = Console.ReadLine();
            Console.Clear();


            Console.WriteLine($"당신은 {input1}년후 {input2}에서 {input3}로서 {input4}를 닮은 사람과 함께 살아갑니다.");
            Console.ReadLine();
            Console.WriteLine("어떤 모험이 기다리고 있을까요?");
            Console.ReadLine();
            Console.WriteLine("다음편을 기대해주세요");
            Console.ReadLine();
            Console.WriteLine("-완-");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
