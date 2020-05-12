using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int min;
            int max;
            Console.Write("숫자를 입력해주세요 : ");
            a[0] = int.Parse(Console.ReadLine());
            min = a[0];
            max = a[0];
            for (int i = 1; i < 5; i++)
            {
                Console.Write("숫자를 입력해주세요 : ");
                a[i] = int.Parse(Console.ReadLine());
                min = min > a[i] ? a[i] : min;
                max = max > a[i] ? max : a[i];
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("가장 큰 수 :" + max); 
            Console.WriteLine("가장 작은 수 :" + min);
        }
    }
}
