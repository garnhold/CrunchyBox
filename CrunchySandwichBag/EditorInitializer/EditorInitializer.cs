using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    [InitializeOnLoad]
    static public class EditorInitializer
    {
        [MenuItem("Edit/Force Initialization")]
        static private void Initialize()
        {
            MarkedMethods<EditorInitializerAttribute>
                .GetFilteredMarkedStaticMethods(
                    Filterer_MethodInfo.HasNoEffectiveParameters()
                ).ProcessSandboxed(
                    m => m.Invoke(null, Empty.Array<object>()),
                    e => Debug.LogException(e)
                );
        }

        static EditorInitializer()
        {
            Initialize();
        }
    }
}