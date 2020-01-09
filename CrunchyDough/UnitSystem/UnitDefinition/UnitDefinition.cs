using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public abstract class UnitDefinition
    {
        private string singular_name;
        private string plural_name;

        private List<string> abbreviations;

        public abstract double ConvertToInternal(double value, double world = 1.0);
        public abstract double ConvertFromInternal(double value, double world = 1.0);

        public UnitDefinition(string sn, string pn, IEnumerable<string> a)
        {
            singular_name = sn;
            plural_name = pn;

            abbreviations = a.ToList();
        }

        public UnitDefinition(string sn, string pn, params string[] a) : this(sn, pn, (IEnumerable<string>)a) { }

        public bool IsLabeledAs(string label)
        {
            if (singular_name.AreSymbolInvariantsEqual(label))
                return true;

            if (plural_name.AreSymbolInvariantsEqual(label))
                return true;

            if (abbreviations.Has(a => a.AreSymbolInvariantsEqual(label)))
                return true;

            return false;
        }

        public double ConvertTo(double value, UnitDefinition unit_definition, double world = 1.0)
        {
            return unit_definition.ConvertFromInternal(ConvertToInternal(value, world), world);
        }
    }
}