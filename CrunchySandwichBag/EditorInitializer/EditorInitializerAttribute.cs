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
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class EditorInitializerAttribute : Attribute
    {
    }
}