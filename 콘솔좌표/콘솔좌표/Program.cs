using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 콘솔좌표
{
    class Program
    {
        static void Main(string[] args)
        {
            ////콘솔 창 크기 설정 
            //Console.SetWindowSize(80, 25); //x 80 , y 25

            ////콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            //Console.SetBufferSize(80, 25);

            //Console.CursorVisible = false; //커서 숨기기


            //Console.Clear(); //화면 지우기
            //Console.SetCursorPosition(0, 0);
            //Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            //Console.SetCursorPosition(0, 1);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 2);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 3);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 4);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 5);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 6);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 7);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 8);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 9);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 10);
            //Console.Write("┃                       대장장이 키우기                                        ┃");
            //Console.SetCursorPosition(0, 11);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 12);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 13);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 14);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 15);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 16);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 17);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 18);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 19);
            //Console.Write("┃                                                                              ┃");
            //Console.SetCursorPosition(0, 20);
            //Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");


            //Thread.Sleep(3000);

            //for(int x=0; x<30; x++)//0-29이동
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(x, 10);
            //    Console.Write("◎");
            //    Thread.Sleep(100);
            //}

            //반복문 제어문 활용

            //콘솔 창 크기 설정 
            Console.SetWindowSize(80, 25); //x 80 , y 25
            //콘솔 버퍼 크기도 설정 (스크롤없이 고정된 창 유지)
            Console.SetBufferSize(80, 25);

            Console.CursorVisible = false; //커서 숨기기
            int pos1 = 40;
            int pos2 = 12;
            int repos1;
            int repos2;


            while (true)
            {


                #region 
                Console.SetCursorPosition(0, 0);
                Console.Write("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
                Console.SetCursorPosition(0, 1);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 2);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 3);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 4);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 4);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 5);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 6);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 7);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 8);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 9);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 10);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 11);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 12);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 13);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 14);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 15);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 16);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 17);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 18);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 19);
                Console.Write("┃                                                                              ┃");
                Console.SetCursorPosition(0, 20);
                Console.Write("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
                #endregion //화면그리기

                //화면그리기
                Console.SetCursorPosition(pos1, pos2);
                Console.Write("◎");

                Console.SetCursorPosition(0, 21);//질문창 좌표
                Console.WriteLine("좌표를입력하시면 그곳으로 공이 이동합니다.(79,20)안으로");



                repos1 = pos1;
                repos1 = pos2;

                Console.Write("X :");
                pos1 = int.Parse(Console.ReadLine());
                Console.Write("Y :");
                pos2 = int.Parse(Console.ReadLine());

                Console.SetCursorPosition(repos1, repos1);
                Console.Write(" ");

                Console.SetCursorPosition(pos1, pos2);
                Console.Write("◎");

                Thread.Sleep(1000);
                Console.Clear();
                
            }






        }
    }
}
