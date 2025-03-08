using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int day = 3;

            //switch(day)
            //{
            //    case 1:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 2:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 3:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 4:
            //        Console.WriteLine("월요일");
            //        break;
            //    case 5:
            //        Console.WriteLine("월요일");
            //        break;
            //    default:
            //        Console.WriteLine("주말입니다.");
            //        break;
            //}

            //alt드래그 꿀팁
            //검사
            //공격력 100
            //방어력 90
            //Console.WriteLine("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적)");
            //int input = int.Parse(Console.ReadLine());

            //switch(input)
            //{
            //    case 1:
            //        Console.WriteLine("검사");
            //        Console.WriteLine("공격력 100");
            //        Console.WriteLine("방어력 90");
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사");
            //        Console.WriteLine("공격력 110");
            //        Console.WriteLine("방어력 80");
            //        break;
            //    case 3:
            //        Console.WriteLine("도적");
            //        Console.WriteLine("공격력 115");
            //        Console.WriteLine("방어력 70");
            //        break;
            //}

            ////반복문

            //for(int i=1; i<=5; i++)
            //{
            //    Console.WriteLine("숫자 : " + i);
            //}
            ////무한반복
            //for (; ; )
            //{
            //    Console.WriteLine("중요한건 꺽이지 않는 마음");
            //}

            ////0부터 9까지 출력 for문활용
            //for(int i=1; i<=9; i++)
            //{
            //    Console.WriteLine(i);
            //}


            ////0부터 9까지 합 출력 for문활용
            //int sum = 0;
            //for (int i = 1; i <= 9; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);

            //int count = 1;

            //while(count<=5)
            //{
            //    Console.WriteLine("count : " + count);
            //    count++;
            //    if(count==3)
            //    {
            //        Console.WriteLine("3일때 반복문 탈출");
            //        break;
            //    }
            //}
            //Console.WriteLine("Count : " + count);

            //랜덤
            //Random rand = new Random();//랜덤객체 생성

            ////0이상 10미만의 랜덤 정수 생성
            //for(int i=0; i<10; i++)
            //{
            //    int randomNumber = rand.Next(0, 10); //0~9
            //    Console.WriteLine("0 이상 10미만의 랜덤 정수 : " + randomNumber);
            //}

            //대장장이 키우기
            //도끼등급 sss 10% ss 40% s 50%

            //Random rand = new Random();

            //int rnd = 0;
            //for(int i=0; i<20; i++)
            //{
            //    rnd = rand.Next(1, 101);
            //    if (1 <= rnd && rnd < 10)
            //        Console.WriteLine("SSS급 도끼");
            //    else if (10 <= rnd && rnd < 40)
            //        Console.WriteLine("SS급 도끼");
            //    else
            //        Console.WriteLine("S급 도끼");
            //    Thread.Sleep(100);
            //}

            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번은 실행됩니다.");
            //    x--;
            //} while (x > 0);

            ////break문 반복문탍출
            //for(int i=1; i<=10; i++)
            //{
            //    if(i==5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}
            ////continue 현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);//홀수만 출력
            //}

            //goto

            int n = 1;
            start:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                goto start; //레이블로 이동
            }
            
        }

    }
}
