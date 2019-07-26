using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Asset_GUID
    {
        static public string GetAssetGUID(this UnityEngine.Object item)
        {
            string guid;
            long local_id;

            if (AssetDatabase.TryGetGUIDAndLocalFileIdentifier(item, out guid, out local_id))
                return guid;

            return null;
        }
    }
}