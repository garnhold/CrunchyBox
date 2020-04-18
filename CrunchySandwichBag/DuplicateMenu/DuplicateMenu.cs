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
    
    static public class DuplicateMenu
    {
        [MenuItem("Assets/Duplicate")]
        static private void Duplicate()
        {
            File.Copy(
                Selection.activeObject.GetAssetPath(),
                Filename.AddFilenameSuffix(Selection.activeObject.GetAssetPath(), "(copy)")
            );
        }

        [MenuItem("Assets/Duplicate", true)]
        static private bool DuplicateValidate()
        {
            if (Selection.activeObject.IfNotNull(o => o.IsAssetSaved()))
                return true;

            return false;
        }
    }
}