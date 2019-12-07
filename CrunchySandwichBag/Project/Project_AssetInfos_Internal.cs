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
        static public IEnumerable<AssetInfo> GetInternalAssetInfos()
        {
            return GetAssetInfos("", Project.GetInternalAssetDirectory())
                .Narrow(a => a.IsInternalAsset());
        }

        static public IEnumerable<AssetInfo> GetInternalAssetInfos(Type type)
        {
            return GetAssetInfos("", Project.GetInternalAssetDirectory(), type)
                .Narrow(a => a.IsInternalAsset());
        }
        static public IEnumerable<AssetInfo> GetInternalAssetInfos<T>()
        {
            return GetInternalAssetInfos(typeof(T));
        }
    }
}