using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    [GetContentIdentityEditDistinction]
    static public class UnityObjectExtensions_ContentIdentity
    {
        [GetContentIdentityEditDistinction]
        static public int GetContentIdentity(UnityEngine.Object item)
        {
            unchecked
            {
                int hash = 17;

                hash = hash * 23 + item.GetAssetInfo().GetTimestamp().GetHashCodeEX();
                hash = hash * 23 + item.GetHashCodeEX();
                return hash;
            }
        }
    }
}