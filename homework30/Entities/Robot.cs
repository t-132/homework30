using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace homework30.Entities
{
    public class Robot : IMyClonable<Robot>, ICloneable, IComparable<Robot>
    {
        protected static int lst_id = 0;
        protected  string _modelNum { get; set; }
        protected  string _name { get; set; }
        protected int _id { get; set; }

        public Robot(string modelNum, string name)
        {
            _modelNum = modelNum;
            _name = name;
            _id = lst_id++;
        }

        public void DoWork()
        {
            CyberHumiliate();
        }

        public void CyberHumiliate()
        {
            Console.WriteLine($"You were cyber humiliated by {_name} ({_modelNum}), id {_id}");
        }

        public Robot CreateClone()
        {
            return new Robot(_modelNum, _name);
        }

        public object Clone()
        {
            return CreateClone();
        }

        public int CompareTo(Robot other)
        {
            if (other is null) return -1;

            return other._modelNum == _modelNum && other._name == _name
                ? 0
                : -1;
        }
    }
}
