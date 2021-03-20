using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//设置当前时间、闹钟时间；每走一刻自动嘀嗒响一声，到达闹铃处产生alarm
//2、使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。
//    在闹钟走时时或者响铃时，在控制台显示提示信息。
namespace _4._2
{
    public delegate void ClockHandler(Time t);
    public class AlarmEventArgs
    {
        
    }

    public class ClockEvent
    {//定义两个事件
        public event ClockHandler Tick;
        public event ClockHandler Alarm;
        public static Time time { get; set; }
        public Time alarmTime { get; set; }
   
        public void openClock(int hour,int min, int sec)
        {
            //设置初始时间 
            time =new Time(hour,min,sec);


        }
        
        public void setAlarm(int hour,int min, int sec)
        {
            alarmTime = new Time(hour, min, sec);//设置响铃时间
            
            while (!time.equals(alarmTime))
            {//触发tick事件
                Tick(time);
            }
            //当到达响铃时间时，触发alarm事件
            Alarm(alarmTime);
        }
        
    }
   
    public class Clock
    {
        public ClockEvent event1 = new ClockEvent();
        public Clock()
        {//为Tick事件添加两个处理方法
            event1.Tick += addTime;
            event1.Tick += showTime;
            //为Alarm事件添加一个方法
            event1.Alarm += showAlarm;
        }
        void addTime(Time t)
        {
                t.addTime();
                
            
        }
        void showTime(Time t)
        {
            Console.WriteLine("现在是{0}：{1}：{2}", t.Hour, t.Minute, t.Second);
        }
        void showAlarm(Time t)
        {
            Console.WriteLine("现在已经到{0}：{1}：{2}了，闹钟响铃！",t.Hour,t.Minute,t.Second);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Clock clock1 = new Clock();
            clock1.event1.openClock(19,34,45);//设置当前时间
            clock1.event1.setAlarm(19,46,30); //设置闹钟响铃时间
        }
    }
}
