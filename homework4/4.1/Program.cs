using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1、为示例中的泛型链表类添加类似于List<T> 类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，
//    求最大值、最小值和求和（使用lambda表达式实现）。

namespace _4._1
{

    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            //for(int i = 0; i < 10; i++)
            //{
            //    intList.add(i);
            //}
            intList.add(1);
            intList.add(2);
            intList.add(3);
            intList.add(4);
            intList.add(5);
            intList.add(6);
            intList.add(7);
            //求最大值
            int max = int.MinValue;
            intList.ForEach(x => max = x > max ? x : max);
            Console.WriteLine($"链表的最大值为：{max}");
            //求最小值
            int min = int.MaxValue;
            intList.ForEach(x => min = x <min ? x : min);
            Console.WriteLine($"链表的最小值为：{min}");
            //打印链表元素
            intList.ForEach(m => Console.WriteLine(m));
            //求和
            int sum = 0;
            intList.ForEach(x => sum += x);
            Console.WriteLine($"链表元素之和为:{sum}"); 
        }
    }
}