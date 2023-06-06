using System;
using System.Collections.Generic;
using System.Text;

namespace homework30.Entities
{
    public class RobotCleaner : WheeledRobot, IMyClonable<RobotCleaner>, ICloneable, IComparable<RobotCleaner>
    {
        protected int _bunckerCapcity { get; set; }
        int _currentCapcity { get; set; }

        public RobotCleaner(string modelNum, string name, int wheelNumbers, int bunckerCapcity) : base(modelNum, name, wheelNumbers)
        {
            _bunckerCapcity = bunckerCapcity;
            _currentCapcity = 0;
        }

        public new void DoWork()
        {
            if (_currentCapcity++ < _bunckerCapcity)
                Console.WriteLine("Clean");
            else
                base.DoWork();
        }

        public new RobotCleaner CreateClone()
        {
            return new RobotCleaner(_modelNum, _name, _wheelNumbers, _bunckerCapcity);
        }

        public new object Clone()
        {
            return CreateClone();
        }

        int IComparable<RobotCleaner>.CompareTo(RobotCleaner other)
        {
            if (other is null)
                return -1;

            if (base.CompareTo((WheeledRobot)other) != 0) return -1;

            return other._bunckerCapcity == _bunckerCapcity
                ? 0
                : -1;
        }
    }
}
