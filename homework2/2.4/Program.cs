using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4
{
    class Program
    {
        public static bool isToeplitz(int[,] a)
        {
            int m = a.GetLength(0);
            int n = a.GetLength(1);
            bool flag = true;
            for (int i = 0; i < m - 1 && i < n - 1; i++)
            {
                if (a[i, i] != a[i + 1, i + 1])
                {
                    flag = false;
                }
            }
            return flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入矩阵行数");
            int M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入矩阵列数");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] c = new int[M, N];
            Console.WriteLine("请按行输入，一行内的元素用空格分开，再回车下一行");
            for (int a = 0; a < M; a++)          //循环行数次，每循环一次输入一行
            {
                string mystring = Console.ReadLine();
                string[] tmp = mystring.Split(" ".ToCharArray());   //以空格作为分隔符将输入的一行字符串分开
                for (int j = 0; j < N; j++)
                {
                    c[a, j] = int.Parse(tmp[j]);      //将分割后的字符赋值给这一行的每个元素
                }
            }
            if (isToeplitz(c))
            {
                Console.WriteLine("您输入的是Toeplitz矩阵");
            }
            else
            {
                Console.WriteLine("您输入的不是Toeplitz矩阵");
            }


        }
    }
}