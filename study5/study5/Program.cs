using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식 : 정수와  실수를 다룰 때 싸용하는 다양한 타입
            //int integerNum = 10; //정수 데이터
            //float floatNum = 3.14f; //단정밀도 실수
            //double doubleNum = 3.14159; //배정밀도 실수

            //Console.Write(integerNum);
            //Console.Write(floatNum);
            //Console.Write(doubleNum);

            ////정수 데이터형식: 소수점이 없는 숫자를 표현
            //int intValue = -100; //4바이트 크기의 정수
            //long longValue = 1234567890L;//8바이트 크기의 정수

            //Console.WriteLine(intValue);//출력: -100;
            //Console.WriteLine(longValue);//출력: 1234567890

            ////1비트  00000000 8 1바이트
            ////부호 있는 정수: 음수와 양수를 모두 표현 가능
            //sbyte signedByte = -50; //1바이트 크기
            //short signedShort = -32000; //2바이트 크기
            //int signedInt = -200000000; // 4바이트 크기

            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            ////부호없는 정수 데이터 형식
            //byte unsignedByte = 255; //1바이트 크기
            //ushort unsignedShort = 65000;//2바이트 크기
            //uint unsigneInt = 400000000;//4바이트 크기
            ////서버쪽에서 부하를 줄이기위해 많이씀 클라는별로안씀

            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsigneInt);

            ////실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f; //단정밀도 실수
            //double doublePrecision = 3.1415926535;//배정밀도 실수(8바이트)
            //decimal highPrecision = 3.141592653511111111m; //고정밀도(16바이트)

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);

            //long longValue = 100L;
            //float floatValue = 23.1f;
            //decimal decimalValue = 2.12432424323432m;

            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(decimalValue);

            //char letter = 'A';
            //char symbol = '#';
            //char number = '9';

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            ////string 형식: 여러 문자를 저장
            //string greeting = "Hello world";//문자열 저장
            //string name = "Alice"; //이름 저장

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);

            ////Hello World Alice
            //Console.WriteLine(greeting +" "+ name);

            ////bool형식 : 참(true) = 1 거짓 (false)=0
            //bool isRunning = true; //프로그램 실행 상태
            //bool isFinished = false; //프로그램 종료 상태

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            //const double Pi = 3.14159; //원주율
            //const int MaxScore = 100; //최대 점수

            //Console.WriteLine(Pi); //출력: 3.14159
            //Console.WriteLine(MaxScore); //출력: 100

            ////닷넷 형식 : 기본 형식의 닷넷표현
            //System.Int32 number = 123; //int 닷넷형식
            //System.String text = "Hello"; //string의 닷넷형식
            //System.Boolean flag = true;//bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            //int 래퍼 형식의 메서드 활용
            int number = 123;

            string numberAsString = number.ToString(); //정수를 문자열로 변환

            //bool 래퍼형식
            bool flag = true;

            string flagAsString = flag.ToString();//논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(flagAsString);

        }
    }
}
