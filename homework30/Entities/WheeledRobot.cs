using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homework30.Entities
{
    public class WheeledRobot : Robot, IMyClonable<WheeledRobot>, ICloneable, IComparable<WheeledRobot>
    {
        protected  int _wheelNumbers { get; set; }
        protected  double _latitude { get; set; }
        protected  double _longitude { get; set; }

        public WheeledRobot(string modelNum, string name, int wheelNumbers) : base(modelNum, name)
        {
            _wheelNumbers = wheelNumbers;
            _latitude = 0;
            _longitude = 0;

        }

        public void moveTo(double latitude, double longitude)
        {
            _longitude = latitude;
            _longitude = longitude;
        }

        public void GetPosition()
        {
            Console.WriteLine($"Current (latitude, longitude): ({_longitude},{_longitude})");
        }

        public new WheeledRobot CreateClone()
        {
            return new WheeledRobot(_modelNum, _name, _wheelNumbers);
        }

        public new object Clone()
        {
            return CreateClone();
        }

        public int CompareTo(WheeledRobot other)
        {
            if (other is null)
                return -1;

            if (base.CompareTo((Robot)other) != 0) return -1;

            return other._wheelNumbers == _wheelNumbers 
                ? 0
                : -1;            
        }
    }
}
