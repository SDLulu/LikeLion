using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _250304
{
    //public class Warrior
    //{
    //    public string Name;
    //    public int Score;
    //    public int Strength;
    //}
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //Warrior warrior = new Warrior();
            //warrior.Name = "ㅇㅁㅇ";
            //warrior.Score = 99;
            //warrior.Strength = 12;

            //Console.WriteLine($"이름 : {warrior.Name} 점수 : {warrior.Score} 힘 : {warrior.Strength}");
            ////2.
            //try
            //{
            //    Console.Write("숫자를 입력하세요 : ");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine("입력된 숫자:" + num);
            //}catch(FormatException ex)
            //{
            //    Console.WriteLine("올바른 숫자를 입력하세요");
            //}
            ////3.
            //List<string> list = new List<string>();
            //list.Add("사과"); list.Add("바나나"); list.Add("포도");
            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("첫번째작업"); queue.Enqueue("두번째작업"); queue.Enqueue("세번째작업");
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10); stack.Push(20); stack.Push(30);

            //foreach(string a in list)
            //{
            //    Console.Write(a + " ");
            //}
            //Console.WriteLine();
            //foreach (string b in queue)
            //{
            //    Console.Write(b+ " ");
            //}
            //Console.WriteLine();
            //foreach (int c in stack)
            //{
            //    Console.Write(c + " ");
            //}
            ////4..
            //Console.Write("문자열입력 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine($"대문자 변환 : {input.ToUpper()} 대체 : {input.Replace("C#","CSharp")}" +
            //    $" 문자열길이 : {input.Length}");
            //5.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            var sum = numbers.Sum();
            foreach(int i in evenNumbers)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine("\n"+sum);

        }
    }
}
