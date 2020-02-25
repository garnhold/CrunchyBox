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
        static public RepresentationResult CreateResults(this CmlClass item, CmlContext context)
        {
            return new RepresentationResult(item.Create(context), context);
        }
    }
}
