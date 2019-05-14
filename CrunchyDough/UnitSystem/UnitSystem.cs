using System;
using System.Collections;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;

namespace CrunchyDough
{
    public class UnitSystem
    {
        private List<UnitDefinition> unit_definitions;

        public UnitSystem()
        {
            unit_definitions = new List<UnitDefinition>();
        }

        public UnitDefinition Add(UnitDefinition unit_definition)
        {
            unit_definitions.Add(unit_definition);

            return unit_definition;
        }

        public double Parse(string measurement, double world = 1.0)
        {
            double value;
            string units;

            if (measurement.TryParseMeasurement(out value, out units))
                return GetUnitDefinitionByLabel(units).ConvertToInternal(value, world);

            return value;
        }
        public double ParseTo(string measurement, UnitDefinition to, double world = 1.0)
        {
            return to.ConvertFromInternal(Parse(measurement, world), world);
        }

        public double Convert(double value, UnitDefinition from, UnitDefinition to, double world = 1.0)
        {
            return from.ConvertTo(value, to, world);
        }
        public double Convert(double value, string from, UnitDefinition to, double world = 1.0)
        {
            return Convert(value, GetUnitDefinitionByLabel(from), to, world);
        }
        public double Convert(double value, UnitDefinition from, string to, double world = 1.0)
        {
            return Convert(value, from, GetUnitDefinitionByLabel(to), world);
        }
        public double Convert(double value, string from, string to, double world = 1.0)
        {
            return Convert(value, GetUnitDefinitionByLabel(from), GetUnitDefinitionByLabel(to), world);
        }

        public UnitDefinition GetUnitDefinitionByLabel(string label)
        {
            return unit_definitions.Find(u => u.IsLabeledAs(label));
        }
    }
}