using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class SpriteExtensions_Id
    {
        static public string GetSpriteId(this Sprite item)
        {
            return item.GetAssetValue<string>("m_SpriteID");
        }
    }
}