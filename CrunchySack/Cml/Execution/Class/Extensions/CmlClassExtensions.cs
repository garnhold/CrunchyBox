using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;

    static public class CmlClassExtensions
    {
        static public RepresentationResult InstanceResults(this CmlClass item, CmlContext context)
        {
            return new RepresentationResult(item.Instance(context), context);
        }
    }
}
