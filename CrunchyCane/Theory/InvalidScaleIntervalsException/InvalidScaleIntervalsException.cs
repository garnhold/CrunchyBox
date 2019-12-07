using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Cane
{
    using Dough;
    
    public class InvalidScaleIntervalsException : ArgumentException
    {
        public InvalidScaleIntervalsException(IEnumerable<double> i) : base("The sum of a scale's intervals must equal 12. (" + i.ToString(", ") + ")") { }
    }
}