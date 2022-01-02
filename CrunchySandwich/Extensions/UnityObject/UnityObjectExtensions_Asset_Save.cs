using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Noodle;
    
    static public class UnityObjectExtensions_Asset_Save
    {
        static public void SaveAssetAdvisory(this UnityEngine.Object item)
        {
            if (Application.isPlaying == false)
            {
                PlayEditDistinction<SaveAssetEditDistinctionAttribute>
                    .ExecuteNoReturnEditDistinction<UnityEngine.Object>(item);
            }
        }
    }

    public class SaveAssetEditDistinctionAttribute : EditDistinctionAttribute { }
}