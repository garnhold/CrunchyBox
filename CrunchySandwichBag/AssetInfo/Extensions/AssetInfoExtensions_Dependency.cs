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
    
    static public class AssetInfoExtensions_Dependency
    {
        static public bool IsDependentOn(this AssetInfo item, AssetInfo dependency)
        {
            return item.IsDependentOnPath(dependency.GetPath());
        }

        static public IEnumerable<AssetInfo> GetDependents(this AssetInfo item)
        {
            return Project.GetAllAssetInfos()
                .Skip(item)
                .Narrow(a => a.IsDependentOn(item));
        }

        static public bool IsReferenced(this AssetInfo item)
        {
            if (item.GetDependents().IsNotEmpty())
                return true;

            return false;
        }
        static public bool IsOrphaned(this AssetInfo item)
        {
            if (item.IsReferenced() == false)
                return true;

            return false;
        }
    }
}