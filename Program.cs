using System;

namespace Text_RPG_1111
{
    class Program
    {
        enum ClassType//클래스타입 설정
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3,
            Prist = 4
        }

        static ClassType ChooseClass()//직업 선택(readline, switch case)
        {
            Console.WriteLine("Text RPG에 오신것을 환영합니다!\n");
            Console.WriteLine("직업을 선탁하세요!");
            Console.WriteLine("[1]기사\n[2]궁수\n[3]마술사\n[4]신관");
            string input = Console.ReadLine();

            ClassType choice = ClassType.None;
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
                case "4":
                    choice = ClassType.Prist;
                    break;
            }
            return choice;
        }

        struct Player//가시값(구조체)
        {
            public int hp;
            public int attack;
        }

        static void CreatePlayer(ClassType choice, out Player player)//직업별 개체값 설정
        {
            //knight(80/30) archer(100/20) mage(60/40) prist(150/20)
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 80;
                    player.attack = 30;
                    break;
                case ClassType.Archer:
                    player.hp = 100;
                    player.attack = 20;
                    break;
                case ClassType.Mage:
                    player.hp = 60;
                    player.attack = 40;
                    break;
                case ClassType.Prist:
                    player.hp = 150;
                    player.attack = 20;
                    break;
                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }
        }

        enum MonsterType//몬스터타입 설정
        {
            None = 0,
            Slime = 1,
            Orc = 2,
            Skeleton = 3,
            Zombie = 4
        }

        struct Monster//몬스터 가시값
        {
            public int hp;
            public int attack;
        }


    }
}

