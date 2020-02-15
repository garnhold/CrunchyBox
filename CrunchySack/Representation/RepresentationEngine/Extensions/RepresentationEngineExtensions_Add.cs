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
        static public T AddAndGetSetInfo<T>(this RepresentationEngine item, T info) where T : RepresentationInfo_Set
        {
            item.AddSetInfo(info);

            return info;
        }
    }
}