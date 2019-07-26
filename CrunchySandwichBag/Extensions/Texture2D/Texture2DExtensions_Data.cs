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
    [SideloadEditDistinctionAttribute]
    static public class Texture2DExtensions_Data
    {
        [SideloadEditDistinctionAttribute]
        static public Texture2D Sideload(Texture2D item)
        {
            return CrunchySandwich.Texture2DExtensions.Create(item.GetAssetInfo().GetBytes());
        }
    }
}