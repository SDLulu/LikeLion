﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다.
            int number = 10; //정수형 리터럴
            double pi = 3.14;//실수형 리터럴
            char letter = 'A';//문자 리터럴
            string name = "Alice";//문자열 리터럴
            Console.WriteLine(number); //출력 : 10
            Console.WriteLine(pi); //출력 : 3.14
            Console.WriteLine(letter); //출력 : A
            Console.WriteLine(name); //출력 : Alice

            //캐릭터
            //hp : 100
            //atk = 56.7
            //캐릭터이름 : ??
            //등급 : S
            int chHp = 100;
            double chAtk = 56.7;
            string chName = "Sam";
            char chRank = 'S';

            Console.WriteLine("캐릭터");
            Console.WriteLine("체력 : "+chHp);
            Console.WriteLine("공격력 : "+chAtk);
            Console.WriteLine("캐릭터이름 : "+chName);
            Console.WriteLine("등급 : "+chRank); 



        }
    }
}
