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
    
    public enum GeneratedCodeType
    {
        RuntimeDefinition,
        RuntimeLeaf,

        EditorOnlyDefinition,
        EditorOnlyLeaf
    }
}