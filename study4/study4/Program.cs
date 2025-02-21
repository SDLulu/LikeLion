using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study4
{
    class Program
    {
        static void Main(string[] args)
        {
            ////문자열
            //string greeting; //문자열 변수를 선언
            //greeting = "Hello world"; //변수에 값을 저장

            ////변수의 값을 사용
            //Console.WriteLine(greeting); //출력 : Hello , World!

            ////변수 선언과 초기화를 한번에 수행
            //int score = 100;//정수형 변수 선언과 동시에 100으로 초기화
            //double temperature = 36.6;//실수형 변수 선언과 초기화
            //string city = "Seoul";//문자열 변수 선언과 초기화

            ////변수 출력
            //Console.WriteLine(score); //출력 100
            //Console.WriteLine(temperature); //출력 36.5
            //Console.WriteLine(city); //출력 : Seoul

            //같은 데이타입의 벼수를 쉼표로 구분해서 선언
            //int x = 10, y = 20, z = 30; //정수형 변수 x,y,z 를 선언과 초기화

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);

            //const double Pi = 3.14159; //상수 pi선언 및 초기화
            //const int MaxScore = 100;

            ////출력
            //Console.WriteLine("Pi : " + Pi); //출력 : pi: 3.14159
            //Console.WriteLine("Max Score " + MaxScore);

            int atk = 16755;
            int hp = 78103;

            int crit = 36;
            int special = 1017;
            int cc = 41;
            int speed = 611;
            int stand = 22;
            int mastery = 39;

            Console.WriteLine("공격력 : "+atk);
            Console.WriteLine("최대 생명력 : "+ hp);

            Console.WriteLine("치명 : "+ crit);
            Console.WriteLine("특화 : "+ special);
            Console.WriteLine("제압 : "+ cc);
            Console.WriteLine("신속 : "+ speed);
            Console.WriteLine("인내 : "+ stand);
            Console.WriteLine("숙련 : "+ mastery);





        }
    }
}
