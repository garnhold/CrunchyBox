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
        static public IEnumerable<AssetInfo> GetExternalAssetInfos()
        {
            return GetAssetInfos("", Project.GetAssetDirectory())
                .Narrow(a => a.IsExternalAsset());
        }

        static public IEnumerable<AssetInfo> GetExternalAssetInfos(Type type)
        {
            return GetAssetInfos("", Project.GetAssetDirectory(), type)
                .Narrow(a => a.IsExternalAsset());
        }
        static public IEnumerable<AssetInfo> GetExternalAssetInfos<T>()
        {
            return GetExternalAssetInfos(typeof(T));
        }
    }
}