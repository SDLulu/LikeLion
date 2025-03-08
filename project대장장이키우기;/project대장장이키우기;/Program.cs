using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project대장장이키우기_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pmoney = 100;
            int input;
            int rnd;

            Random rand = new Random();

            Console.WriteLine("대장장이키우기");

            Thread.Sleep(1000);

            while(true)
            {
                Console.Clear(); //화면지우기
                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.WriteLine("입력 : ");
                input = int.Parse(Console.ReadLine());

                if(input==1)//나무캐기
                {
                    while(true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : " + pmoney);
                        if(str=="x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if(input==2)//장비뽑기
                {
                    if(pmoney >= 1000)//돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;
                        //20번 뽑기
                        for(int i=1; i<=20; i++)
                        {
                            rnd = rand.Next(1, 101);
                            if(rnd==1)
                            {
                                Console.WriteLine("도끼등급SSS");
                            }
                            else if(rnd >=2 && rnd<=6)
                            {
                                Console.WriteLine("도끼등급SS");
                            }
                            else if(rnd>=7 && rnd<=17)
                            {
                                Console.WriteLine("도끼등급S");
                            }
                            else if(rnd >= 18 && rnd<=38)
                            {
                                Console.WriteLine("도끼등급A");
                            }
                            else if(rnd>=39 && rnd<=69)
                            {
                                Console.WriteLine("도끼등급B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급C"); ;
                            }
                            Thread.Sleep(1000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다.");
                        Thread.Sleep(1000);
                    }
                }
                else if(input==3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
