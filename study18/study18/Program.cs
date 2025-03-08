using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study18
{
    struct Point
    {
        public int x;
        public int y;
    }

    struct Student
    {
        public string Name;
        public int iKor;
        public int iEng;
        public int iMath;
        //학생 정보 출력 함수
        public void Print()
        {
            Console.WriteLine($"{Name,-3} {iKor,5} {iEng,7}{iMath,8}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Point[] points = new Point[2];

            //points[0].x = 10;
            //points[0].y = 10;

            //points[1].x = 20;
            //points[1].y = 20;



            //foreach (var point in points)
            //{
            //    Console.WriteLine($"Point: ({point.x},{point.y})");
            //}

            //구조체를 이용해 학생 3명의 성적 받고 국영수 출력
            //이름    국어    영어    수학
            //홍길동    100    80    70
            //홍길란    90    10    20
            //홍길순    20    55    70

            //학생 배열 선언
            Student[] students = new Student[3];

            for(int i=0; i< students.Length; i++)
            {
                Console.WriteLine("학생 성적 입력하세요");
                Console.Write("학생이름 : ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어 : ");
                students[i].iKor = int.Parse(Console.ReadLine());
                Console.Write("영어 : ");
                students[i].iEng = int.Parse(Console.ReadLine());
                Console.Write("수학 : ");
                students[i].iMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어    영어    수학");
            foreach(Student std in students)
            {
                std.Print();
            }

        }
    }
}
