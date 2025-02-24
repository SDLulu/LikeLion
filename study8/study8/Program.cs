using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            ////비교연산자
            ////두 값을 ㄱ비교하여 관계를 평가한다.
            //// == 같다 != 같지않다 a<b c>b <= =>
            //int x = 5, y = 10;

            //Console.WriteLine(x == y);//false
            //Console.WriteLine(x != y);//true
            //Console.WriteLine(x < y);//true
            //Console.WriteLine(x > y); //false
            //Console.WriteLine(x >= y); //false
            //Console.WriteLine(x <= y);//true

            ////논리연산자
            //bool a = true;
            //bool b = false;

            //Console.WriteLine(a && b);
            ////AND : 1:1 t
            ////      1:0 f
            ////      0:1 f
            ////      0:0 f
            //Console.WriteLine(a || b);
            ////OR  : 1:1 t
            ////      1:0 t
            ////      0:1 t
            ////      0:0 f

            ////NOT
            ////!a
            //b = !a;
            //Console.WriteLine(b);//false

            ////비트연산자
            //int x = 5; //0101
            //int y = 3; //0011

            //Console.WriteLine(x & y);//AND:1(0001)
            //Console.WriteLine(x | y);//OR:7(011)
            //Console.WriteLine(x ^ y);//XOR:6(0110)
            //Console.WriteLine(~x);//NOT:-6

            //int value = 4; //0100
            //Console.WriteLine(value << 1);//왼쪽이동:8(1000)
            //Console.WriteLine(value >> 2);//오른쪽이동:2(0010)

            //int a = 10, b = 20;
            //int max;
            //max = (a > b) ? a : b;//삼항연산자
            //Console.WriteLine(max);
            ////()안이 맞으면 왼쪽꺼 아니면 오른쪽꺼

            //int key = 1;

            //string str;
            //str = (key == 1) ? "문이열렸습니다." : "문을 못열였습니다.";

            //Console.WriteLine(str);

            //int result = 10 + 2 * 5;//곱셉이 덧셈보다우선
            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;//괄호 우선순위 먼저계산
            //Console.WriteLine(adjustedResult);

            //조건문

            //int score = 85;

            //if (score >= 90)
            //{
            //    Console.WriteLine("A학점");
            //}
            //else if(score>=80)

            //{
            //    Console.WriteLine("B학점");
            //}
            //else if (score >= 700)
            //{
            //    Console.WriteLine("C학점");
            //}
            //else
            //{
            //    Console.WriteLine("F학점");
            //}

            //string GameID = "멋사검존";

            //if(GameID == "멋사검존")
            //{
            //    Console.WriteLine("아이디일치");
            //}
            //else
            //{
            //    Console.WriteLine("아이디불일치");
            //}

            //1단계
            //가지고 있는 소지금을 입력하세요:
            //0~100 무한의대검 +1
            //101~200 카타나 +2
            //201~300 진은검 +3
            //301~400 집판검 +4
            //401~500 엑스칼리버 +5
            //501~600 유령검 +6
            //2단계
            //캐릭터이름
            //무기:소지중인 무기이름표시
            //공격력:100+1

            //int money = 0;
            //string name="devil";
            //string weapon = "";
            //int atk=0;

            //Console.Write("캐릭터이름 입력:");
            //name = Console.ReadLine();
            //Console.Write("가지고있는소지금 입력:");
            //money = int.Parse(Console.ReadLine());

            //if(0<=money && money<=100)
            //{
            //    weapon = "무한의대검";
            //    atk += 1;
            //}
            //else if (101 <= money && money <= 200)
            //{
            //    weapon = "카타나";
            //    atk += 2;
            //}
            //else if (201 <= money && money <= 300)
            //{
            //    weapon = "진은검";
            //    atk += 3;
            //}
            //else if (301 <= money && money <= 400)
            //{
            //    weapon = "집판검";
            //    atk += 4;
            //}
            //else if (401 <= money && money <= 500)
            //{
            //    weapon = "엑스칼리버";
            //    atk += 5;
            //}
            //else if (501 <= money && money <= 600)
            //{
            //    weapon = "유령검";
            //    atk += 6;
            //}
            //else
            //{
            //    weapon = "전설의검";
            //    atk += 7;
            //}

            //Console.WriteLine(name);
            //Console.WriteLine(weapon);
            //Console.WriteLine("공격력 100+" + atk);

            //2/24 오후문제

            //문제 1.세 정수의 최대값 구하기
            //문제 설명:
            //사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            //요구사항:
            //사용자에게 세 개의 정수를 입력받습니다.
            //if문을 사용하여 가장 큰 정수를 결정합니다.
            //결과를 “최대값: X” 형식으로 출력합니다.

            Console.WriteLine("문제1");
            Console.WriteLine("===========================================");
            int a, b, c;
            Console.Write("정수 a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("정수 b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("정수 c:");
            c = int.Parse(Console.ReadLine());

            int max = a;
            if (a >= b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            if (c >= max)
            {
                max = c;
            }
            Console.WriteLine("최대값 : " + max);


            //문제 2.점수에 따른 학점 평가
            //문제 설명:
            //학생의 점수를 입력받아 아래 기준에 따라 학점을 출력하는 프로그램을 작성하세요.
            //90 이상: A 학점
            //80 이상 90 미만: B 학점
            //70 이상 80 미만: C 학점
            //60 이상 70 미만: D 학점
            //60 미만: F 학점

            Console.WriteLine("문제2");
            Console.WriteLine("===========================================");
            int score;
            Console.WriteLine("점수 입력: ");
            score = int.Parse(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("A학점");
            }
            else if (score >= 80)

            {
                Console.WriteLine("B학점");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C학점");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C학점");
            }
            else
            {
                Console.WriteLine("F학점");
            }

            //문제 3.간단한 사칙연산 계산기
            //문제 설명:
            //사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            //요구사항:

            //두 개의 숫자와 연산자 기호를 입력받습니다.
            //if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            //나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            //결과는 “결과: X” 형식으로 출력합니다.

            Console.WriteLine("문제3");
            Console.WriteLine("===========================================");
            int num1, num2, result;
            result = 0;
            string op;

            Console.WriteLine("숫자1 입력: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("숫자2 입력: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("연산자 입력(+,-,*,/): ");
            op = Console.ReadLine();

            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;

            Console.WriteLine($"{num1}{op}{num2}결과 :{result}");

            

        }
    }
}
