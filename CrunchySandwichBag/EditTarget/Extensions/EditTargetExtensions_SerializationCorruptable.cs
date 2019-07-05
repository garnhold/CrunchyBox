using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class EditTargetExtensions_SerializationCorruptable
    {
        static public bool IsSerializationNotCorrupt(this EditTarget item)
        {
            if (item.IsSerializationCorrupt() == false)
                return true;

            return false;
        }
    }
}