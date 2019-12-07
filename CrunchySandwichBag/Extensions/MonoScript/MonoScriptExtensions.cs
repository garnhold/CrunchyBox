using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Bun;
    
    static public class MonoScriptExtensions
    {
        static public void SetExecutionOrder(this MonoScript item, int order)
        {
            if (order != MonoImporter.GetExecutionOrder(item))
                MonoImporter.SetExecutionOrder(item, order);
        }
    }
}