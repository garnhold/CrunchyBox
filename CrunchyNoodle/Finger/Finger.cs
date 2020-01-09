using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    
    public class Finger<T> : Finger
    {
        public Finger(T o) : base(o) { }
    }

    public class Finger
    {
        private object obj;

        public Finger(object o)
        {
            obj = o;
        }

        public override int GetHashCode()
        {
            return obj.GetFingerPrintEX();
        }

        public override bool Equals(object obj)
        {
            return obj.IsFingerEquivolentEX(obj);
        }
    }
}