using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
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