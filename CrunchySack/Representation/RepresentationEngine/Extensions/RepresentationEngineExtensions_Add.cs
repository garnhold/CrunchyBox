using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    static public partial class RepresentationEngineExtensions_Add
    {
        static public T AddAndGetInfoSet<T>(this RepresentationEngine item, T info) where T : RepresentationInfoSet
        {
            item.AddInfoSet(info);

            return info;
        }
    }
}