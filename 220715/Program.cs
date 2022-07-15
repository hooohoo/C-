using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _220715
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int a = 100;
            int b = 200;
            int c = 10;
            bool result = (a > b);
            Console.WriteLine(result);                              // f
            Console.WriteLine(!result);                             // t

            Console.WriteLine(a != b);                             // t
            Console.WriteLine((a != b) || (a <= b));         // t   
            Console.WriteLine(!(a != b) || (a <= b));        // t
            Console.WriteLine((a != b) && (a <= b) && (a == c));    //f
            Console.WriteLine((a != b) || (a <= b) && (a == c));     //t
            */

            /*
            int a = 2;
            a *= 4;
            Console.WriteLine(a);

            int b = 10;
            b %= 2;
            Console.WriteLine(b);

            int c = 10;
            c /= 2;
            Console.WriteLine(c);

            bool d = true;
            d = !d;
            Console.WriteLine(d);
            */

            byte a = 1;
            byte b = 9;
            byte c = 7;
            byte d = 5;

            // 8개의 비트를 갖는 BitArray객체 생성
            BitArray mybit = new BitArray(8);
            mybit.Set(0, true);
            mybit.Set(1, true);
            // PrintBits(mybit);

            int j = 100;
            int k = 200;
            int l = j & k;
            string s = Convert.ToString(l, 2).PadLeft(32, '0');
            Console.WriteLine(s);
            
        }

        /*
        static void PrintBits(BitArray ba)
        {
            for(int i = 0; i < ba.Count; i++)
            {
                Console.WriteLine(ba[i] ? "1" : "0");
            }
            Console.WriteLine();
        }
        */
    }
}
