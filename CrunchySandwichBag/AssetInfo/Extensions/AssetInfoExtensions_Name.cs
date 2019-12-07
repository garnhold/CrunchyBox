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
    
    static public class AssetInfoExtensions_Name
    {
        static public string GetName(this AssetInfo item)
        {
            return Filename.GetFilenameWithoutExtension(item.GetPath());
        }
    }
}