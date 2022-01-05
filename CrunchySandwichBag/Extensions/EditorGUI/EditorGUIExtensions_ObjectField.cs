using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public partial class EditorGUIExtensions
    {
        static public T ObjectField<T>(Rect rect, T value) where T : UnityEngine.Object
        {
            return EditorGUI.ObjectField(rect, value, typeof(T), false).Convert<T>();
        }
    }
}