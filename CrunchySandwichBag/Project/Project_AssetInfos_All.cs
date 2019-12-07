using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    
    static public partial class Project
    {
        static public IEnumerable<AssetInfo> GetAllAssetInfos()
        {
            return GetAssetInfos("", Project.GetAssetDirectory());
        }

        static public IEnumerable<AssetInfo> GetAllAssetInfos(Type type)
        {
            return GetAssetInfos("", Project.GetAssetDirectory(), type);
        }
        static public IEnumerable<AssetInfo> GetAllAssetInfos<T>()
        {
            return GetAllAssetInfos(typeof(T));
        }
    }
}