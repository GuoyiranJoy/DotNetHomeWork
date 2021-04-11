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
                
                Width = w;
                Height = h;
            }
            public int GetArea()
            {
                if (!isValid())
                {
                    throw new InvalidOperationException("长方形的长和宽必须大于零！");
                }
                else { return Width * Height; }
            }
            public bool isValid()
            {
                return Width >0&&Height>0;
            }
        }

        public class Square : Rectangle
        {
           
        public int Side
        {
            set; get;
        }
        public Square(int side):base(side, side)
            {
                this.Side=side;
            }

        }
        public class Triangle : Shape
        {
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
                Length=v1;
                Height=v2;
            }


            public int GetArea()
            {
                if (!isValid())
                {
                    throw new InvalidOperationException("三角形的长和高必须大于零!");
                }
                else
                {
                    return (Height * Length) / 2;
                }
            }
            public bool isValid()
            {
                return Length > 0 && Height >0;
            }
        }
        class InvalidOperationException : Exception
        {
            public InvalidOperationException(string message) : base(message)
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
