using System;
using Xunit;
using homework30.Entities;

namespace XUnitHomework30
{
    public class UnitTest
    {
        [Fact]
        public void Test1()
        {
            var r11 = new Robot("x1", "r1");            
            var r12 = r11.CreateClone();            
            var r13 = (Robot)r12.Clone();            

            var r21 = new WheeledRobot("x2", "r2", 1);            
            var r22 = r21.CreateClone();            
            var r23 = (WheeledRobot)r22.Clone();

            var r31 = new RobotCleaner("x3", "r3", 4, 0);
            var r32 = r31.CreateClone();
            var r33 = (RobotCleaner)r32.Clone();

            Assert.IsType(r11.GetType(), r12);
            Assert.IsType(r11.GetType(), r13);
            Assert.Equal(0, r11.CompareTo(r12));
            Assert.Equal(0, r11.CompareTo(r13));

            Assert.IsType(r21.GetType(), r22);
            Assert.IsType(r21.GetType(), r23);
            Assert.Equal(0, r21.CompareTo(r22));
            Assert.Equal(0, r21.CompareTo(r23));


            Assert.IsType(r31.GetType(), r32);
            Assert.IsType(r31.GetType(), r33);
            Assert.Equal(0, r31.CompareTo(r32));
            Assert.Equal(0, r31.CompareTo(r33));
        }
    }
}
