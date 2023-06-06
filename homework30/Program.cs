using System;
using homework30.Entities;
using Xunit;

namespace homework30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r1 = new Robot("x1", "r1");
            r1.DoWork();

            var r2 = r1.CreateClone();
            r2.DoWork();

            var r3 = (Robot) r2.Clone();
            r3.DoWork();

            var r11 = new WheeledRobot("x2", "r2",1);
            r11.moveTo(1, 1);
            r11.DoWork();
            r11.GetPosition();

            var r12 = r11.CreateClone();
            r12.moveTo(1, 1);
            r12.DoWork();
            r12.GetPosition();

            var r13 = (WheeledRobot)r12.Clone();
            r13.moveTo(1, 1);
            r13.DoWork();
            r13.GetPosition();

            var r21 = new RobotCleaner("x3", "r3", 4, 0);
            r21.moveTo(2, 0);
            r21.DoWork();
            r21.GetPosition();

            var r22 = r21.CreateClone();
            r22.moveTo(2, 0);
            r22.DoWork();
            r22.GetPosition();

            var r23 = (RobotCleaner)r22.Clone();
            r23.moveTo(2, 0);
            r23.DoWork();
            r23.GetPosition();

            Console.ReadKey();
        }
    }
}
