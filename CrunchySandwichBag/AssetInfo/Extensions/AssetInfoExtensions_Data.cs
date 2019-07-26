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
    static public class AssetInfoExtensions_Data
    {
        static public string GetText(this AssetInfo item)
        {
            return File.ReadAllText(item.GetPath());
        }

        static public byte[] GetBytes(this AssetInfo item)
        {
            return File.ReadAllBytes(item.GetPath());
        }
    }
}