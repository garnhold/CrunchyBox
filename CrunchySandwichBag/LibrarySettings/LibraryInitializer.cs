using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
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
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<LibrarySettings>(),
                Filterer_Type.IsConcreteClass()
            ).Convert(t => t.CreateInstance<LibrarySettings>());
        }
    }
}