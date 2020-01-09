using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class UnityObjectExtensions_Asset_Modify
    {
        static public void ModifyAsset(this UnityEngine.Object item, Process<SerializedObject> process)
        {
            SerializedObject obj = new SerializedObject(item);

            process(obj);

            obj.ApplyModifiedProperties();
        }

        static public void ModifyAssetImporter(this UnityEngine.Object item, Process<SerializedObject> process)
        {
            AssetImporter importer = item.GetAssetImporter();

            importer.ModifyAsset(process);

            importer.Reserialize();
            importer.SaveAndReimport();
        }
    }
}