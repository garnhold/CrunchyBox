using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Asset_Importer
    {
        static public AssetImporter GetAssetImporter(this UnityEngine.Object item)
        {
            return AssetImporter.GetAtPath(item.GetAssetPath());
        }
        static public T GetAssetImporter<T>(this UnityEngine.Object item) where T : AssetImporter
        {
            return item.GetAssetImporter().Convert<T>();
        }
    }
}