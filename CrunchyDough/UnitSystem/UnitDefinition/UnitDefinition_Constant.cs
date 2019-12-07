using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class UnitDefinition_Constant : UnitDefinition
    {
        private double constant;

        public UnitDefinition_Constant(string n, double c, IEnumerable<string> a) : base(n, n, a)
        {
            constant = c;
        }

        public UnitDefinition_Constant(string n, double c, params string[] a) : this(n, c, (IEnumerable<string>)a) { }

        public override double ConvertToInternal(double value, double world = 1.0)
        {
            return constant;
        }

        public override double ConvertFromInternal(double value, double world = 1.0)
        {
            return constant;
        }
    }
}