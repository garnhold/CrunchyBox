using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Sandwich;
    
    [EditorInitializer]
    static public class ScriptExecutionOrderAttributeInitializer
    {
        [EditorInitializer]
        static private void Initilize()
        {
            MonoImporter.GetAllRuntimeMonoScripts()
                .Narrow(m => m.GetClass().CanBeTreatedAs<MonoBehaviour>())
                .TryNarrow((MonoScript m, out ScriptExecutionOrderAttribute a) => m.GetClass().TryGetCustomAttributeOfType<ScriptExecutionOrderAttribute>(false, out a))
                .Process(p => p.item1.SetExecutionOrder(p.item2.GetOrder()));
        }
    }
}