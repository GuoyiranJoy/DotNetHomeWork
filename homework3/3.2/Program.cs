using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework3;

namespace homework4
{
    class Program
    {
        public class ShapeFactory
        {
            public Shape makeShape(int typeNum,Random ran)
            {
                
                switch (typeNum)
                {
                    case 0:
                        int width =ran.Next(1,10);
                        int height = ran.Next(1,10);
                        return new Rectangle(width, height);
                        
                    case 1:
                        int side = ran.Next(1,10);
                        return new Square(side);

                    case 2:
                        int length = ran.Next(1,10);
                        int height2 = ran.Next(1,10);
                        return new Triangle(length, height2);

                    default:
                        return null;
                }
            }
        }
        static void Main(string[] args)
        {
            ShapeFactory myFactory = new ShapeFactory();
            Random ran = new Random();
            int sum=0;
            for(int i = 0; i < 10;i++)
            {
                //生成若干个随机数时 Random ran = new Random();要放在循坏外面！！        

                int type = ran.Next(0,3);
                Shape s = myFactory.makeShape(type,ran);
                sum += s.GetArea();
                Console.WriteLine("生成了一个{0}，它的面积为{1}", s.GetType().ToString(), s.GetArea());
                
            }
            Console.WriteLine("这些形状的面积之和为{0}", sum);
        }
    }
}
