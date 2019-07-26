using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class AssetInfoExtensions_Name
    {
        static public string GetName(this AssetInfo item)
        {
            return Filename.GetFilenameWithoutExtension(item.GetPath());
        }
    }
}