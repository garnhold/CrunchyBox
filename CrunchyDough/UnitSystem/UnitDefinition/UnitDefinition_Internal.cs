using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class UnitDefinition_Internal : UnitDefinition
    {
        public UnitDefinition_Internal(string sn, string pn, IEnumerable<string> a) : base(sn, pn, a) { }
        public UnitDefinition_Internal(string sn, string pn, params string[] a) : this(sn, pn, (IEnumerable<string>)a) { }

        public override double ConvertToInternal(double value, double world = 1.0)
        {
            return value;
        }

        public override double ConvertFromInternal(double value, double world = 1.0)
        {
            return value;
        }
    }
}