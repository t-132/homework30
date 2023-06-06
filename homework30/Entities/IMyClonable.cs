using System;
using System.Collections.Generic;
using System.Text;

namespace homework30.Entities
{
    public interface IMyClonable<T>  where T : class
    {
        T CreateClone();
    }
}
