using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class PixelMeasurer : UnitSystem
    {
        public readonly double dpi;

        public readonly UnitDefinition pixels;

        public readonly UnitDefinition ratio;
        public readonly UnitDefinition percent;

        public readonly UnitDefinition inches;
        public readonly UnitDefinition feet;
        public readonly UnitDefinition yards;
        public readonly UnitDefinition miles;

        public readonly UnitDefinition millimeters;
        public readonly UnitDefinition centimeters;
        public readonly UnitDefinition meters;
        public readonly UnitDefinition kilometers;

        public readonly UnitDefinition picas;
        public readonly UnitDefinition points;

        public PixelMeasurer(double d)
        {
            dpi = d;

            pixels = Add(new UnitDefinition_Internal("pixel", "pixels", "px", "pxs"));

            ratio = Add(new UnitDefinition_Ratio("ratio", "ratio"));
            percent = Add(new UnitDefinition_ThatIsNThis("percent", "percents", ratio, 100.0, "%"));

            inches = Add(new UnitDefinition_ThisIsNThat("inch", "inches", dpi, pixels, "in", "''", "\""));
            feet = Add(new UnitDefinition_ThisIsNThat("foot", "feet", 12.0, inches, "ft", "'"));
            yards = Add(new UnitDefinition_ThisIsNThat("yard", "yards", 3.0, feet, "yd"));
            miles = Add(new UnitDefinition_ThisIsNThat("mile", "miles", 5280.0, feet, "mi"));

            centimeters = Add(new UnitDefinition_ThatIsNThis("centimeter", "centimeters", inches, 2.54, "cm"));
            meters = Add(new UnitDefinition_ThisIsNThat("meter", "meters", 100.0, centimeters, "m"));
            millimeters = Add(new UnitDefinition_ThatIsNThis("millimeter", "millimeters", meters, 1000.0, "mm"));
            kilometers = Add(new UnitDefinition_ThisIsNThat("kilometer", "kilometers", 1000.0, meters, "km"));

            picas = Add(new UnitDefinition_ThatIsNThis("pica", "picas", feet, 72.0, "pc", "pcs"));
            points = Add(new UnitDefinition_ThatIsNThis("point", "points", picas, 12.0, "pt", "pts"));
        }
    }
}