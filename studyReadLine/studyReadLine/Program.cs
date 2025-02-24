using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine(); //사용자로 부터 입력받기

            //Console.WriteLine($"안녕하세요, {userName}님!");

            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); //사용자로부터 입력 받기
            //int age = int.Parse(input); //문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");
            //Console.WriteLine("내년에는"+ age + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0} 살이 되겠군요!", age);
            ////다 되는데 맨위에거가 최근 추가댄 문법 (가독성굳)

            //해당 스샷내용
            //루인 스킬 피해 : 4.5<-입력받기

            string input;

            Console.Write("스킬 피해량을 입력하세요 : ");
            input = Console.ReadLine();
            float skill_Damage = int.Parse(input);
            Console.Write("카드 게이지 획득량을 입력하세요 : ");
            input = Console.ReadLine();
            float card_Gage = int.Parse(input);
            Console.Write("각성기 피해량을 입력하세요 : ");
            input = Console.ReadLine();
            float ultimate_Damage = int.Parse(input);
            Console.Write("최대 마나를 입력하세요 : ");
            input = Console.ReadLine();
            float mana = int.Parse(input);
            Console.Write("전투중 마나 회복량을 입력하세요 : ");
            input = Console.ReadLine();
            float manaFightRecycle = int.Parse(input);
            Console.Write("비전투중 마나 회복량을 입력하세요 : ");
            input = Console.ReadLine();
            float manaNonFightRecycle = int.Parse(input);
            Console.Write("이동속도를 입력하세요 : ");
            input = Console.ReadLine();
            float moveSpeed = int.Parse(input);
            Console.Write("탈 것 속도를 입력하세요 : ");
            input = Console.ReadLine();
            float ridingMoveSpeed = int.Parse(input);
            Console.Write("운반 속도를 입력하세요 : ");
            input = Console.ReadLine();
            float transportSpeed= int.Parse(input);
            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            input = Console.ReadLine();
            float skillCooldownDecrease = int.Parse(input);

            Console.WriteLine();
            Console.WriteLine($"스킬 피해량               : {skill_Damage}%");
            Console.WriteLine($"카드 게이지 획득량        : {card_Gage}%");
            Console.WriteLine($"각성기 피해량             : {ultimate_Damage}");
            Console.WriteLine($"최대 마나를               : {mana}");
            Console.WriteLine($"전투중 마나 회복량        : {manaFightRecycle}");
            Console.WriteLine($"비전투중 마나 회복량      : {manaNonFightRecycle}");
            Console.WriteLine($"이동속도                  : {moveSpeed}%");
            Console.WriteLine($"탈 것 속도를              : {ridingMoveSpeed}%");
            Console.WriteLine($"운반 속도를               : {transportSpeed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 : {skillCooldownDecrease}%");




        }
    }
}
