using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInfo;

namespace _220713
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            a = a + 1;
            Console.WriteLine(a);

            /*
            int b;          -> 오류. 초기화 시키지 않은 변수
            b = b + 1;
            */

            Character user1;
            user1 = new Character();

            user1.attack();
            int userLevel = user1.getLevel();
            int result = user1.sum(4, 6);
            float fResult = user1.fSum(1.1f, 2.2f, 3.3f);

            string sentence = user1.concat("안녕", "하세요");
            Console.WriteLine(sentence);

            fResult = user1.fMulti(1.2f, 3.4f, 2.0f);
            Console.WriteLine(fResult);
        }
    }
}
