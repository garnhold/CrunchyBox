using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwichBag
{
    static public class MonoScriptExtensions
    {
        static public void SetExecutionOrder(this MonoScript item, int order)
        {
            if (order != MonoImporter.GetExecutionOrder(item))
                MonoImporter.SetExecutionOrder(item, order);
        }
    }
}