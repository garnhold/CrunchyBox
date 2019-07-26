﻿using System;
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
    static public class AssetInfoExtensions_DependencyPath
    {
        static public IEnumerable<string> GetDependencyPaths(this AssetInfo item, bool recursive)
        {
            return AssetDatabase.GetDependencies(item.GetPath(), recursive);
        }

        static public bool IsDependentOnPath(this AssetInfo item, string dependency)
        {
            if (item.GetDependencyPaths(true).Has(dependency))
                return true;

            return false;
        }
    }
}