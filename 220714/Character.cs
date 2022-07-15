using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Character
{
    public class Character
    {


        // 이름, 레벨, 생명력, 나이, 직업, 이동속도
        // 공격, 이동, 레벨업, 스킬

        private string name;
        private int level = 1;
        private int hp = 100;
        private int age = 1;
        private string job;
        private int speed = 50;

        public Character() { }

        public Character(string _name, string _job)
        {
            this.name = _name;
            this.job = _job;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int LEVEL
        {
            get { return level; }
            set { level = value; }
        }

        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public int AGE
        {
            /*
            get { return age; }
            set { age = value; }
            */
            get;
            set;
        }

        public string JOB
        {
            /*
            get { return job; }
            set { job = value; }
            */
            get;
            set;
        }

        public int SPEED
        {
            //get { return speed; }
            //set { speed = value; }
            get;
            set;
        }

        /*
         
        public string GetName()
        {
            return this.name;
        }

        public void SetName(string _name)
        {
            this.name = _name;
        }

        public int GetLevel()
        {
            return this.level;
        }

        public void SetLevel(int _level)
        {
            this.level = _level;
        }

        public int GetHp()
        {
            return this.hp;
        }

        public void SetHp(int _hp)
        {
            this.hp = _hp;
        }

        public int SetAge()
        {
            return this.age;
        }

        public void SetAge(int _age)
        {
            this.age = _age;
        }

        public string GetJob()
        {
            return this.job;
        }

        public void SetJob(string _job)
        {
            this.job = _job;
        }

        public int GetSpeed()
        {
            return this.speed;
        }

        public void SetSpeed(int _speed)
        {
            this.speed = _speed;
        }
        */

        // 공격
        public void attack()
        {
            Console.WriteLine("플레이어가 공격합니다.");
        }

        // 이동
        public void move()
        {
            Console.WriteLine("플레이어가 이동합니다.");
        }

        // 레벨업
        public void levelUp()
        {
            this.level++;
            Console.WriteLine("레벨업! 레벨 : " + this.level);
        }

        // 스킬
        public void skill()
        {
            Console.WriteLine("플레이어가 스킬을 사용했습니다.");
        }

    }
}
