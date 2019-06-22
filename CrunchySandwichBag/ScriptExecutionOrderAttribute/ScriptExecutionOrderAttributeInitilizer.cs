﻿using System;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [InitializeOnLoad]
    static public class ScriptExecutionOrderAttributeInitializer
    {
        static private void Initilize()
        {
            MonoImporter.GetAllRuntimeMonoScripts()
                .Narrow(m => m.GetClass().CanBeTreatedAs<MonoBehaviour>())
                .TryNarrow((MonoScript m, out ScriptExecutionOrderAttribute a) => m.GetClass().TryGetCustomAttributeOfType<ScriptExecutionOrderAttribute>(false, out a))
                .Process(p => p.item1.SetExecutionOrder(p.item2.GetOrder()));
        }

        static ScriptExecutionOrderAttributeInitializer()
        {
            Initilize();
        }
    }
}