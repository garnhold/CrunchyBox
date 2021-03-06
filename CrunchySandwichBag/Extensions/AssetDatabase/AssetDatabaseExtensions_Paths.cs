﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Salt;    using Sandwich;
    
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