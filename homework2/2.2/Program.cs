using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        public static float calSum(int[] a)
        {
            int sum = 0;
            foreach (int num in a)
            {
                sum += num;
            }
            return sum;
        }
        public static int calMax(int[] a)
        {
            int max = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > a[max])
                    max = i;
            }
            return a[max];
        }
        public static int calMin(int[] a)
        {
            int min = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < a[min])
                {
                    min = i;
                }

            }
            return a[min];
        }
        public static float calAve(int[] a)
        {
            float x = calSum(a) / a.Length;
            return x;
        }
        static void Main(string[] args)
        {
            Console.Write("输入数组元素的数量：");
            int n = int.Parse(Console.ReadLine());

            // 定义数组，并输入
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("输入第{0}个元素:", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("数组的最大值为：" + calMax(a));
            Console.WriteLine("数组的最小值为：" + calMin(a));
            Console.WriteLine("数组的平均值为：" + calAve(a));
            Console.WriteLine("数组的和为：" + calSum(a));
        }
    }
}
