﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace study20
{
    //마린 클래스를 만드세요.
    //이름,미네랄50
    //기본생성자, 인자있는생성자

        //기본생성자 
        //클래스가 객체로 생성될때 자동으로 실행되는 특별한 메서드
        //클래스와 같은이름가지며, 반환형이 없다 (void도 사용하지않음)
        //객체를 만들때 필요한 초기값을 설정할대 사용많이한다.

    class Marin
    {
        public string name;
        public int mineral;

        public Marin()
        {
            this.name = "Marin";
            this.mineral = 50;
        }
        public Marin(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }
        public void showInfo()
        {
            Console.WriteLine($"이름 : {name} 미네랄 : {mineral}");
        }
    }

    class SCV
    {
        public string Name;
        public int Mineral;

        public SCV()
        {
            Name = "SCV";
            Mineral = 50;
        }

        public SCV(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }

    class Barrack
    {
        public string name;
        public int mineral;

        public Barrack()
        {
            this.name = "Barrack";
            this.mineral = 150;
        }
        public Barrack(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
        }
        public void showInfo()
        {
            Console.WriteLine($"이름 : {name} 미네랄 : {mineral}");
        }
    }

    class Mineral
    {
        public int MineralCount;
        public Mineral()
        {
            MineralCount = 1500;
        }

        public void showInfo()
        {
            Console.WriteLine($"현재 미네랄 개수: {MineralCount}");
        }
    }

    class Game
    {
        public static int mineral;
        public static int gas;
        public static int charCount;
        
        public static void showInfo()
        {
            Console.WriteLine($"미네랄 {mineral} 가스 {gas} 인구수 {charCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game.mineral = 50;
            Game.gas = 0;
            Game.charCount = 4;
            Game.showInfo();

            Marin marin = new Marin("불꽃테란",100);
            SCV scv = new SCV("열받은SCV", 70);
            Barrack barrack = new Barrack("배럭", 150);
            //클래스의 배열
            Mineral[] mineral = new Mineral[7];
            //{   new Mineral(),
            //    new Mineral(),
            //    new Mineral(),
            //    new Mineral(),
            //    new Mineral(),
            //    new Mineral(),
            //    new Mineral(),};

            for(int i=0; i<mineral.Length;i++)
            {
                mineral[i] = new Mineral();
                mineral[i].showInfo();
            }
            

            marin.showInfo();
            scv.ShowInfo();
            barrack.showInfo();

        }
    }
}
