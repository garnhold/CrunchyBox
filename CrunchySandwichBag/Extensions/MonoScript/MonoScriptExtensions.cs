using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class MonoScriptExtensions
    {
        static public void SetExecutionOrder(this MonoScript item, int order)
        {
            if (order != MonoImporter.GetExecutionOrder(item))
                MonoImporter.SetExecutionOrder(item, order);
        }

        static public long GetFileId(this MonoScript item)
        {
            string guid;
            long file_id;

            AssetDatabase.TryGetGUIDAndLocalFileIdentifier(item, out guid, out file_id);
            return file_id;
        }
    }
}