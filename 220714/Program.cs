using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Character;

namespace _220714
{
    class Program
    {
        static void Main(string[] args)
        {
            Character user = new Character();
            /*
            user.SetName("kim");
            user.SetJob("knight");
            Console.WriteLine("캐릭터 이름 : " + user.GetName());
            Console.WriteLine("캐릭터 직업 : " + user.GetJob());
            */


            user = new Character("캐릭터1", "검사");

           // Console.WriteLine("캐릭터 이름 : " + user.GetName());
           //Console.WriteLine("캐릭터 직업 : " + user.GetJob());

            Character user2 = new Character("양준혁", "암살자");
            Character user3 = new Character("이승엽", "창술사");
            user2.JOB = "검사";

            Console.WriteLine(user2.Name + "의 직업 : " + user2.JOB);
            Console.WriteLine(user2.Name + "의 스피드 : " + user2.SPEED);
            Console.WriteLine(user3.Name + "의 스피드 : " + user2.SPEED);
            user2.SPEED = 100;
            Console.WriteLine(user2.Name + "의 스피드 : " + user2.SPEED);
            Console.WriteLine(user2.Name + "의 체력 : " + user2.HP);
            Console.WriteLine(user2.Name + "의 직업 : " + user2.JOB);
            Console.WriteLine(user2.Name + "의 나이 : " + user2.AGE);

        }
    }
}
