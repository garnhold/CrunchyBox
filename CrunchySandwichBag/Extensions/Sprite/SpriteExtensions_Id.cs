using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    using Sandwich;
    
    static public class SpriteExtensions_Id
    {
        static public string GetSpriteId(this Sprite item)
        {
            return item.GetAssetValue<string>("m_SpriteID");
        }
    }
}