using System;

using CrunchyDough;

namespace CrunchyBread
{
    public class AxisFilter_Invert : AxisFilter
    {
        public override float Filter(float value)
        {
            return -value;
        }
    }
}