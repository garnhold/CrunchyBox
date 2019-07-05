using System;
using System.Reflection;
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
    static public class PrefabsInitializer
    {
        [CodeGenerator]
        static private void GeneratePrefabs()
        {
            PrefabsSettings.GetInstance().GeneratePrefabs();
        }

        [EditorInitializer]
        static private void Initilize()
        {
            PrefabsSettings.GetInstance().PopulatePrefabs();
        }
    }
}