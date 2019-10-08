using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
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