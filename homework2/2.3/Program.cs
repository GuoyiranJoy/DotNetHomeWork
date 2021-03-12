using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class Program
    {
        public static void isPrime(int[] a)
        {

            for (int divisor = 2; divisor <= 100; divisor++)
            {
                int num = divisor * divisor;
                while (num <= 100)
                {
                    if (num % divisor == 0 && a[num] == 1)
                    {
                        a[num] = 0;//如果数组中的num是divisor的倍数，则它从数组中剔除
                    }
                    num++;
                }
            }

        }

        static void Main(string[] args)
        {
            int[] data = new int[102];
            for (int i = 2; i <= 100; i++)
            {
                data[i] = 1;
            }
            isPrime(data);
            Console.WriteLine("2-100中的素数有：");
            for (int i = 2; i <= 100; i++)
            {
                if (data[i] == 1)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
