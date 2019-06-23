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
    static public class UnityObjectExtensions_Asset_Modify
    {
        static public void ModifyAsset(this UnityEngine.Object item, Process<SerializedObject> process)
        {
            SerializedObject obj = new SerializedObject(item);

            process(obj);

            obj.ApplyModifiedProperties();
        }
    }
}