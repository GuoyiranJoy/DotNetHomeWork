using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2
{
    public class Time
    {
        public int Hour { set; get; }
        public int Minute { set; get; }
        public int Second { set; get; }
        public Time(int hour, int min, int sec)
        {

            Hour = hour;
            Minute = min;
            Second = sec;
        }
        public void addTime()
        {
            Second++;
            if (Second >= 60)
            {
                Second = 0;
                Minute++;
            }
            if (Minute >= 60)
            {
                Minute = 0;
                Hour++;
            }
            if (Hour >= 24)
            {
                Hour = 0;
            }
        }
        public bool equals(Time t)
        {
            return this.Hour == t.Hour && this.Minute == t.Minute && this.Second == t.Second;
        }
        public bool isValid(Time t)
        {
            return 0<=t.Hour<24&&
        }
    }
}
