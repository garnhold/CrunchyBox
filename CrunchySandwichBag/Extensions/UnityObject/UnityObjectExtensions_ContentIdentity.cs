using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
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