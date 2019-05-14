using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class UnitDefinition_Ratio : UnitDefinition
    {
        public UnitDefinition_Ratio(string sn, string pn, IEnumerable<string> a) : base(sn, pn, a) { }
        public UnitDefinition_Ratio(string sn, string pn, params string[] a) : this(sn, pn, (IEnumerable<string>)a) { }

        public override double ConvertToInternal(double value, double world = 1.0)
        {
            return world * value;
        }

        public override double ConvertFromInternal(double value, double world = 1.0)
        {
            return value / world;
        }
    }
}