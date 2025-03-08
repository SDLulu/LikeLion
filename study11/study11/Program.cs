using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace study11
{
    class Program
    {
        ////메모리 영역
        ////스택 (stack) int a
        ////힙 (heap) new
        ////정적메모리 (static memory)
        ////static int count = 0; //정적 메모리에 저장됨
        ////프로그램 종료전까지 유지됨


        ////1단계함수
        ////반환형 함수이름 (매개변수)
        ////{
        ////}
        ////1단계 기본형
        //static void Loading()
        //{

        //    Console.WriteLine("로딩중.");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("로딩중..");
        //    Thread.Sleep(1000);
        //    Console.WriteLine("로딩중...");
        //    Thread.Sleep(1000);
        //}

        ////2단계
        ////입력
        //static void AttackFunction(int Attack)
        //{
        //    Console.WriteLine("공격력은 : " + Attack);
        //}
        ////3단계
        ////출력
        //static int BaseAttack()
        //{
        //    //기본공격력 10
        //    int attack = 10;

        //    return attack;
        //}
        //static int Add(int a, int b)
        //{
        //    return a + b;
        //}

        static void Main(string[] args)
        {
            //int Attack = 0;
            //int BAttack = 0;
            //Console.WriteLine("캐릭터의 공격력을 입력 : ");
            //Attack = int.Parse(Console.ReadLine());

            ////기본 공격력
            //BAttack = BaseAttack();

            //AttackFunction(BAttack+Attack);

            ////두수를 더하는 함수를 만들어서 오류를 해결하세요.
            //int result = Add(10, 20);
            //Console.WriteLine($"10 + 20 = {result}");

            //string[] fruits = { "사과", "바나나", "체리" };
            ////반복문
            //foreach(string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            // 문제: 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.
            //예상 출력

            //복사
            //편집
            //10 20 30 40 50

            ////문제1 크기가 5인 정수 배열을 만들고,{10, 20, 30 ,40, 50}값을 저장한 후 에 출력하세요.
            //int[] array = { 10, 20, 30, 40, 50 };
            //for(int i=0; i<array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            ////문제2 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요
            //int[] array2 = new int[5];
            //int sum = 0;
            //Console.Write("숫자 입력 : ");
            //for(int i=0;i<5;i++)
            //{
            //    array2[i] = int.Parse(Console.ReadLine());
            //    sum += array2[i];
            //}
            //Console.WriteLine("총 합 : " + sum);
            ////문제3 정수배열 {3,8,15,6,2}에서 가장 큰 값을 찾아 출력
            //int[] array3 = { 3, 8, 15, 6, 2 };
            //int max = array3[0];
            //for (int i = 0; i < array3.Length; i++)
            //{
            //    if (max < array3[i])
            //        max = array3[i];
            //}
            //Console.WriteLine("최대값 : " + max);
            ////문제4 for문을 사용하여 1부터 10까지 출력
            //for(int i=1;i<10;i++)
            //{
            //    Console.Write(i + " ");
            //}
            ////문제5 while문을 사용하여 1~10까지 중 짝수만 출력
            //int num = 1;
            //while(num <= 10)
            //{
            //    if (num % 2 == 0)
            //        Console.Write(num + " ");
            //    num++;
            //}
            ////문제6 foreach문을 사용해 배열 {1,2,3,4,5}의 요소 출력
            //int[] array6 = { 1, 2, 3, 4, 5 };
            //foreach(int a in array6)
            //{
            //    Console.Write(a + " ");
            //}
            ////문제7 두개의 정수를 입력받아 합을 반환하는 함수를 작성
            //Console.Write("정수1: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("정수2: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write($"{a}와{b}의 합{Plus(a, b)}");
            ////문제8 문자열을 입력받아 길이를 반환하는 함수 작성
            //Console.Write("문자열 입력: ");
            //string str = Console.ReadLine();
            //Console.Write("문자열 길이: "+StrLength(str));
            //문제9 정수 세개를 입력받아 가장 큰 값을 반환하는 함수 작성
            Console.Write("정수1: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("정수2: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("정수3: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.Write($"{a1}와{b1}와{c1}중 가장 큰 수는 {Max(a1, b1,c1)}");

        }
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int StrLength(string str)
        {
            return str.Length ;
        }
        static int Max(int a, int b , int c)
        {
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;

            return max;
        }

    }
}
