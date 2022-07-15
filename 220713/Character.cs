using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInfo
{
    // 접근 한정자 private은 자신의 클래스에서만 사용하도록 해준다.
    // 외부로 공개되지 않는다.
    public class Character
    {
        private string name;
        private int level;
        private int age;
        private char gender;

        public int getLevel()
        {
            return level;
        }

        public void attack()
        {
            Console.WriteLine("공격함수 호출");
        }

        public void move()
        {
            Console.WriteLine("이동함수 호출");
        }

        public int sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public float fSum(float num1, float num2, float num3)
        {
            return num1 + num2 + num3;
        }

        public string concat(string s1, string s2)
        {
            return s1 + s2;
        }

        public float fMulti(float f1, float f2, float f3)
        {
            return f1 * f2 * f3;
        }
    }
}
