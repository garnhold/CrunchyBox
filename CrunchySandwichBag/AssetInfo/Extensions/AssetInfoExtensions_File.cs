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
    
    static public class AssetInfoExtensions_File
    {
        static public string GetPath(this AssetInfo item)
        {
            return AssetDatabase.GUIDToAssetPath(item.GetGUID());
        }

        static public string GetDirectory(this AssetInfo item)
        {
            return Filename.GetDirectory(item.GetPath());
        }

        static public DateTime GetTimestamp(this AssetInfo item)
        {
            return Files.GetFileTimestamp(item.GetPath());
        }
    }
}