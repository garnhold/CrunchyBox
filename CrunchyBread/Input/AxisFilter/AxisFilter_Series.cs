using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyBread
{
    public class AxisFilter_Series : AxisFilter
    {
        private List<AxisFilter> filters;

        public AxisFilter_Series(IEnumerable<AxisFilter> f)
        {
            filters = f.ToList();
        }

        public AxisFilter_Series(params AxisFilter[] f) : this((IEnumerable<AxisFilter>)f) { }

        public override float Filter(float value)
        {
            return filters.Apply(value, (v, f) => f.Filter(v));
        }
    }
}