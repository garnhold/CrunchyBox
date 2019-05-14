using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class UnityObjectExtensions_Asset_Get
    {
        static public bool IsAssetSaved(this UnityEngine.Object item)
        {
            if (item.GetAssetPath().IsVisible())
                return true;

            return false;
        }

        static public bool IsAssetFolder(this UnityEngine.Object item)
        {
            return AssetDatabase.IsValidFolder(AssetDatabase.GetAssetPath(item));
        }

        static public string GetAssetPath(this UnityEngine.Object item)
        {
            string path = AssetDatabase.GetAssetPath(item);

            if(item.IsAssetFolder())
                return path + "/";

            return path;
        }

        static public string GetAssetDirectory(this UnityEngine.Object item)
        {
            return Filename.GetDirectory(item.GetAssetPath());
        }

        static public T GetAssetInfo<T>(this UnityEngine.Object item, Operation<T, string> operation)
        {
            string path = item.GetAssetPath();

            if (path.IsVisible())
                return operation.Execute(path);

            return default(T);
        }

        static public DateTime GetAssetCreationDate(this UnityEngine.Object item)
        {
            return item.GetAssetInfo(f => File.GetCreationTimeUtc(f));
        }

        static public DateTime GetAssetLastWriteDate(this UnityEngine.Object item)
        {
            return item.GetAssetInfo(f => File.GetLastWriteTimeUtc(f));
        }

        static public DateTime GetAssetLastAccessDate(this UnityEngine.Object item)
        {
            return item.GetAssetInfo(f => File.GetLastAccessTimeUtc(f));
        }

        static public string GetAssetText(this UnityEngine.Object item)
        {
            return item.GetAssetInfo(f => File.ReadAllText(f));
        }

        static public byte[] GetAssetBytes(this UnityEngine.Object item)
        {
            return item.GetAssetInfo(f => File.ReadAllBytes(f));
        }
    }
}