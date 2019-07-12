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
                ).Process(delegate(MethodInfoEX method) {
                    try
                    {
                        method.Invoke(null, Empty.Array<object>());
                    }
                    catch (Exception ex)
                    {
                        Debug.LogException(ex);
                    }
                });
        }

        static EditorInitializer()
        {
            Initialize();
        }
    }
}