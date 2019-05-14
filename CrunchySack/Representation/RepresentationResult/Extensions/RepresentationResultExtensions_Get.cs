using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySack
{
    static public class RepresentationResultExtensions_Get
    {
        static public T GetRepresentation<T>(this RepresentationResult item)
        {
            return item.GetRepresentation().Convert<T>();
        }
    }
}