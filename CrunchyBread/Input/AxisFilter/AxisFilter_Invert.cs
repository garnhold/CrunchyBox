using System;

namespace Crunchy.Bread
{
    using Dough;
    
    public class AxisFilter_Invert : AxisFilter
    {
        public override float Filter(float value)
        {
            return -value;
        }
    }
}