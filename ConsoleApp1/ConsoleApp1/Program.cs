﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入一个数");
            string s1 = Console.ReadLine();
            double n1 = Double.Parse(s1);
            Console.Write("请输入运算符");
            string s2 = Console.ReadLine();
            Console.Write("请再输入一个数");
            string s3 = Console.ReadLine();
            double n2 = Double.Parse(s3);
            switch (s2)
            {
                case "+":
                    Console.WriteLine(s1+"+"+s3+"=" + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine(s1 + "-" + s3 + "=" + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine(s1 + "*" + s3 + "=" + (n1 * n2));
                    break;
                case "/":
                    Console.WriteLine(s1 + "/" + s3 + "=" + (n1 / n2));
                    break;

                default:
                    Console.WriteLine("输入错误运算符");
                    break;
            }
        }
    }
}
