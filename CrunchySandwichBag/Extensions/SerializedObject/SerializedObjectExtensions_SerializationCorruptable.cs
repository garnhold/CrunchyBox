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
    static public class SerializedObjectExtensions_SerializationCorruptable
    {
        static public bool IsSerializationCorrupt(this SerializedObject item)
        {
            if (item.targetObjects.Convert<SerializationCorruptable>().Has(c => c.IsSerializationCorrupt()))
                return true;

            return false;
        }
    }
}