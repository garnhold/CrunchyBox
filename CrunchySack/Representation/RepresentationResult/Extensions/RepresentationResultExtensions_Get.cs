using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    
    static public class RepresentationResultExtensions_Get
    {
        static public T GetRepresentation<T>(this RepresentationResult item)
        {
            return item.GetRepresentation().Convert<T>();
        }
    }
}