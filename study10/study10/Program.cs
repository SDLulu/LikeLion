using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {
            ////배열
            ////0부터시작
            //int[] num = new int[3]; //3개 메모리 만들겟다.

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 3 };//간단한 선언과 초기화
            //int[] numbers2 = new int[3];//크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 3 };//초기화와 함께선언

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(numbers2[i]);
            //}

            //string[] fruits = { "사과", "바나나", "오렌지" };

            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            ////3명의 국영수 점수를 입력받고 총점과 평균을 출력하세요

            //int[] iKor = new int[3];
            //int[] iEng = new int[3];
            //int[] iMath = new int[3];

            //int[] sum = new int[3];
            //float[] aver = new float[3];

            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("학생 성적입력하세요 : ");
            //    Console.Write("국어 : ");
            //    iKor[i] = int.Parse(Console.ReadLine());
            //    Console.Write("영어 : ");
            //    iEng[i] = int.Parse(Console.ReadLine());
            //    Console.Write("수학 : ");
            //    iMath[i] = int.Parse(Console.ReadLine());
            //    sum[i] = iKor[i] + iEng[i] + iMath[i];
            //    aver[i] = (float)sum[i] / 3;
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("학생"+(i+1)+" : ");
            //    Console.WriteLine($" 국어 : {iKor[i]}점 영어 : {iEng[i]}점 수학 : {iMath[i]}점  총점 : {sum[i]}점 평균 : {aver[i].ToString("F2")}점");

            //}

            ////1차원 배열
            //int[] scores = new int[3];
            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;

            //for(int i=0; i<scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            //}

            //double value = 123.456789;
            ////소수점 자리수 설정하는 포맷
            //Console.WriteLine(value.ToString("F2"));
            //Console.WriteLine($"소수점둘째자리 : {value:F2}");
            //Console.WriteLine(String.Format("소수점 둘째자리:{0:F2}", value));
            ////소수점 없이 정수 출력
            //Console.WriteLine(value.ToString("F0"));

            //double value = 123124124.12323;

            //Console.WriteLine(value.ToString("N2"));//1000단위마다쉼표

            //2차원 배열 선언
            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{matrix[i, j]}");
            //    }
            //    Console.WriteLine();
            //}

            //int[][] matrix = new int[2][];

            //matrix[0] = new int[3];
            //matrix[1] = new int[3];

            ////값입력
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;

            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;

            ////출력
            //for(int i=0; i<matrix.Length; i++)
            //{
            //    for(int j=0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //가변배열
            //Console.WriteLine("가변배열");
            //int[][] jaggedArray = new int[3][];

            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //for(int i=0; i<jaggedArray.Length; i++)
            //{
            //    for(int j=0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write($"{jaggedArray[i][j]}");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입 : {numbers.GetType()}");

        }
    }
}
