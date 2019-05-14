using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class UnitDefinition_ThisIsNThat : UnitDefinition
    {
        private double multiplier;
        private UnitDefinition unit_definition;

        public UnitDefinition_ThisIsNThat(string sn, string pn, double n, UnitDefinition u, IEnumerable<string> a) : base(sn, pn, a)
        {
            multiplier = n;
            unit_definition = u;
        }

        public UnitDefinition_ThisIsNThat(string sn, string pn, double n, UnitDefinition u, params string[] a) : this(sn, pn, n, u, (IEnumerable<string>)a) { }

        public override double ConvertToInternal(double value, double world = 1.0)
        {
            return unit_definition.ConvertToInternal(value * multiplier, world);
        }

        public override double ConvertFromInternal(double value, double world = 1.0)
        {
            return unit_definition.ConvertFromInternal(value, world) / multiplier;
        }
    }
}