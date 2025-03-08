using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study16
{
    class Program
    {
        //열거형이란?
        //Enumeration  enum 
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있는 값으로 표현 가능
        //기본적으로 첫 번째 값은 0부터 시작하며 1씩 증가

        //기본적인 enum 사용법
        enum DayOfWeek
        {
            Sunday,   //0
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        //2.enum  값 변경 (0부터 시작하지않기)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unauthorized = 401,
            NotFound = 404
        }
        enum WeoponType
        {
            Sword,
            Bow,
            Staff
        }
        static void ChooseWeapon(WeoponType weapon)
        {
            if(weapon == WeoponType.Sword)
            {
                Console.WriteLine("검 선택");
            }
            else if (weapon == WeoponType.Bow)
            {
                Console.WriteLine("활 선택");
            }
            else if(weapon == WeoponType.Staff)
            {
                Console.WriteLine("지팡이 선택");
            }
        }
        static void Main(string[] args)
        {
            //DayOfWeek today = DayOfWeek.Wednesday;
            ////숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리 가능
            //Console.WriteLine(today);
            //Console.WriteLine((int)today);

            //StatusCode status = StatusCode.NotFound;
            //Console.WriteLine(status);
            //Console.WriteLine((int)status);

            //문제
            //열거형과 함수를 이용해서 풀기
            //Weapontype.Sword 검을 선택,활,지팡이
            //ChooseWeaopon(WeaponType.Bow); //출력: 활을 선택햇습니다.

            ChooseWeapon(WeoponType.Bow);

        }
    }
}
