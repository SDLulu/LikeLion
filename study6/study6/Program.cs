using System;
using System.Diagnostics.CodeAnalysis;

namespace study6
{
    class Program
    {
        static void Main(string[] args)
        {
            ////이진수를 정수로변환
            //Console.Write("2진수를 입력하세요:");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); //2진수 -> 10진수 변환

            ////정수를 이진수로 변환
            //string binaryOutput = Convert.ToString(decimalValue, 2); //10진수 -> 2진수

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환 : {decimalValue}");
            //Console.WriteLine($"다시 이진수로 변환 : {binaryOutput}");

            ////var를 사용하여 변수 선언
            //var name = "Alice"; //문자열롤 추론
            //var age = 25;
            //var isStudent = true; //논리값으로 추론

            //Console.WriteLine($"이름 : {name}, 나이: {age}, 학생 여부 : {isStudent}");

            ////defalut 키워드 사용한 기본값 설정
            //int defalutInt = default; //기본값 : 0
            //string dsfalutstring = default; //기본값 : null
            //bool defalutBool = default; //기본값 : false

            //Console.WriteLine($"정수 기본값: {defalutInt}");
            //Console.WriteLine($"문자열 기본값: {dsfalutstring}");
            //Console.WriteLine($"논리값 기본값: {defalutBool}");

            //int a = 5, b = 3;

            //int sum = 0;

            //sum = a + b;//산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");
            //sum = a - b;//산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");
            //sum = a * b;//산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");
            //sum = a / b;//산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");
            //sum = a % b;//산술 연산자 사용
            //Console.WriteLine($"합 : {sum}");

            //int number = 7;

            //int sum = 0;

            //sum = number % 2; // 0나오면 짝수 1 나오면 홀수

            //Console.WriteLine("짝수 홀수 판별 : " + sum);

            //bool isEqual = false; //거짓 0

            //int a = 5;
            //int b = 5;

            ////관계형 연산자

            //isEqual = (a == b); //a 랑 b가 같은가?
            //Console.WriteLine($"같은가? {isEqual}");

            ////단항 연산자

            //int number = 5;
            //bool flag = true;

            //Console.WriteLine(+number); //양수 출력 : 5
            //Console.WriteLine(-number); //음수 출력 : -5
            //Console.WriteLine(!flag);//false출력

            ////~비트 반전
            ////10 1010
            ////   0101

            //int num = 10;
            //int result = ~num; //모든 비트 반전

            //Console.WriteLine("원래 값 : "+ num);
            //Console.WriteLine("~ 연산자 적용 값 : "+result);

            ////캐스팅
            //double pi = 3.14;
            //int integerPi = (int)pi;//실수형 ->정수형으로 변환

            //Console.WriteLine(integerPi); //3

            //int iKor = 90;
            //int iEng = 75;
            //int iMath = 58;

            //int sum = 0;
            //float average = 0.0f;

            //sum = iKor + iEng + iMath;
            //average = (float)sum / 3;
            //Console.WriteLine("총점 : " + sum);
            //Console.WriteLine("평균 : " + average);

            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            //문자열 연결 연산자

            //string firstName = "Alice";
            //string lastName = "smith";

            //Console.WriteLine(firstName + " " + lastName);

            //int a = 10;
            //a += 5; // a = a + 5;
            //Console.WriteLine(a);
            //a -= 5; // a = a - 5;
            //Console.WriteLine(a);
            //a *= 5; // a = a * 5;
            //Console.WriteLine(a);
            //a /= 5; // a = a / 5;
            //Console.WriteLine(a);
            //a %= 5; // a = a % 5;
            //Console.WriteLine(a);

            //문제1 학점 평균 계산 프로그램
            //국영수 점수입력받아 총점과 평균구하기
            //정수형으로받고 평균구할때 합 실수로 캐스팅
            //평균은 소수점 둘째자리까지출력

            //문제
            //Console.WriteLine("국어 : ");
            //int kor = int.Parse(Console.ReadLine());
            //Console.WriteLine("영어 : ");
            //int eng = int.Parse(Console.ReadLine());
            //Console.WriteLine("수학 : ");
            //int math = int.Parse(Console.ReadLine());

            //int sum = 0;
            //float average = 0.0f;
            //sum = kor + eng + math;
            //average = (float)sum / 3;

            //Console.WriteLine($"합 : {sum}\n평균 : {average.ToString("F2")}");

            //Console.WriteLine("문제2 숫자입력 : ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("원래값 : "+num);
            //Console.WriteLine("~연산자 적용 : " + ~num);

            //증감 연산자
            int b = 3;
            //전위 ++b, 후위 b++
            Console.WriteLine("b의 값은 : " + (b++));
            Console.WriteLine("b의 값은 : " + b);






        }
    }
}
