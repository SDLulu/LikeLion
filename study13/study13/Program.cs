using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//네임 스페이스
//클래스, 함수, 변수 이름이 충돌하는것을 방지하기위해 사용된다.
//

namespace study13
{
    class Program
    {
        //params 키워드 (가변 매개변수)
        static int Sum(params int[] numbers)
        {
            int total = 0;

            foreach(int num in numbers)
            {
                total += num;
            }
            return total;
        }
        //재귀함수(자기자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1)
                return 1;   //출력겸 탈출

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(Sum(1, 2, 3)); //출력 6
            //Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); //출력 6

            //Factorial(5) = 5 * 4 * 3 * 2 * 1 = 120
            Console.WriteLine(Factorial(5));
        }
    }
}
