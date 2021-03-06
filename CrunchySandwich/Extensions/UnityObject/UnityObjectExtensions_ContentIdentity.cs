using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    static public class UnityObjectExtensions_ContentIdentity
    {
        static public int GetContentIdentity(this UnityEngine.Object item)
        {
            return PlayEditDistinction<GetContentIdentityEditDistinctionAttribute>
                .Execute(i => i.GetHashCodeEX(), item);
        }
    }

    public class GetContentIdentityEditDistinctionAttribute : EditDistinctionAttribute { }
}