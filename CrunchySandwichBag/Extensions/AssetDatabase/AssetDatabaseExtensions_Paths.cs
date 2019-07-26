using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySalt;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public partial class AssetDatabaseExtensions
    {
        static public bool DoesAssetPathExist(string path)
        {
            if (AssetDatabase.GetAllAssetPaths().Has(path))
                return true;

            return false;
        }
    }
}