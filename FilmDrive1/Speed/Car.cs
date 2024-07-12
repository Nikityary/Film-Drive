using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Speed
{
    internal class Car
    {
        Random random = new Random();
        double AllSpeed = 0;
        double SredSpeed;
        double time = 0;
        double OstSec;
        double MsSpeed;

        double speed = 0;
        public void Road(double road)
        {
            double doroga = road;
            for (; doroga > 0; doroga = doroga - MsSpeed)
            {
                SredSpeed = (SredSpeed + Speed()) / 2;
                MsSpeed = Speed() / 3.6;
                OstSec = doroga / (SredSpeed / 3.6);
                Console.WriteLine("текущая скорость: " + Speed() + " км/ч");
                Console.WriteLine("средняя скорость: " + Math.Round(SredSpeed, 0) + " км/ч");
                Console.WriteLine("осталось ехать: " + Math.Round(doroga, 2) + " м");
                Console.WriteLine("времени до прибытия: " + Math.Round(OstSec, 2) + " c\n");
                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException e)
                {
                    Console.WriteLine(e);
                }
            }
            Console.WriteLine("вы разбились");
            Console.ReadLine();
        }
        public double Speed()
        {
            speed = speed + random.Next(8);
            if (speed > 90)
            {
                speed = speed - 3;
            }
    
            return speed;
        }
    }
}
