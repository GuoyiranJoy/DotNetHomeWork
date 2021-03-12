using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
        public static string findFactor(int n)
        {
            string s = "";
            int i = 2;
            while (i * i < n)
            {
                if (n % i == 0)//i是因子
                {
                    s = s + i + " ";
                    n /= i;
                }
                else
                {
                    i++;
                }
            }
            s += n;
            return s;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("输入一个整数");
            string s = Console.ReadLine();
            int n = int.Parse(s);
            string s1 = findFactor(n);
            Console.WriteLine(n + "的素数因子为" + s1);
        }
    }
}

