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
    
    static public class AssetInfoExtensions_Resolve
    {
        static public T Resolve<T>(this AssetInfo item)
        {
            return item.Resolve().Convert<T>();
        }
    }
}