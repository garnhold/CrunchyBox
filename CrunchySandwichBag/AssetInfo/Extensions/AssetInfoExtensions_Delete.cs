using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    static public class AssetInfoExtensions_Delete
    {
        static public void Delete(this AssetInfo item)
        {
            AssetDatabase.DeleteAsset(item.GetPath());
        }
    }
}