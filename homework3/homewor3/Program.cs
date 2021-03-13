using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public interface Shape
        {
            int GetArea();
           
                
            bool isValid();
        }
    public class Rectangle:Shape
        {
            private int width;
            private int height;
            public int Width
        {
            set;get;
        }
            public int Height
            {
                set;get;
            }
            public Rectangle(int w,int h)
            {
                
                width = w;
                height = h;
            }
            public int GetArea()
            {
                if (!isValid())
                {
                    throw new MyException("长方形的长和宽必须大于零！");
                }
                else { return width * height; }
            }
            public bool isValid()
            {
                return width >0&&height>0;
            }
        }

        public class Square : Rectangle
        {
            private int side;
        public int Side
        {
            set; get;
        }
        public Square(int side):base(side, side)
            {
                this.side=side;
            }

        }
        public class Triangle : Shape
        {
            private int length;
            private int height;
        public int Length
        {
            set; get;
        }
        public int Height
        {
            set; get;
        }

        public Triangle(int v1, int v2)
            {
                length=v1;
                height=v2;
            }


            public int GetArea()
            {
                if (!isValid())
                {
                    throw new MyException("三角形的长和高必须大于零!");
                }
                else
                {
                    return (height * length) / 2;
                }
            }
            public bool isValid()
            {
                return length > 0 && height >0;
            }
        }
        class MyException : Exception
        {
            public MyException(string message) : base(message)
            {

            }
        }
    public class Program
    {
        
        
        static void Main(string[] args)
        {
            Triangle t = new Triangle(7,4);
            Square s = new Square(5);
            Rectangle r = new Rectangle(2, 5);

            Console.WriteLine(t.GetArea());
            Console.WriteLine(s.GetArea());
            Console.WriteLine(r.GetArea());
        }
    }
}
