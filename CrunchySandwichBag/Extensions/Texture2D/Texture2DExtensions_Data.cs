using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    using Sandwich;
    
    [SideloadEditDistinctionAttribute]
    static public class Texture2DExtensions_Data
    {
        [SideloadEditDistinctionAttribute]
        static public Texture2D Sideload(Texture2D item)
        {
            return Crunchy.Sandwich.Texture2DExtensions.Create(item.GetAssetInfo().GetBytes());
        }
    }
}