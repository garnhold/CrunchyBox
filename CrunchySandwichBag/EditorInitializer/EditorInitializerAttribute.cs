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
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class EditorInitializerAttribute : Attribute
    {
    }
}