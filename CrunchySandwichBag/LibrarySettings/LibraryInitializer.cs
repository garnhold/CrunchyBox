using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    [CodeGenerator]
    [EditorInitializer]
    static public class LibraryInitializer
    {
        [CodeGenerator]
        static private void GenerateLibrarys()
        {
            InstanceLibrarySettings().Process(s => s.GenerateLibraryClass());
        }

        [EditorInitializer]
        static private void Initilize()
        {
            InstanceLibrarySettings().Process(s => s.InitializeLibraryClass());
        }

        static private IEnumerable<LibrarySettings> InstanceLibrarySettings()
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<LibrarySettings>(),
                Filterer_Type.IsConcreteClass()
            ).Convert(t => t.CreateInstance<LibrarySettings>());
        }
    }
}