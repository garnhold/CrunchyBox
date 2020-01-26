using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedObjectExtensions_SerializedProperty
    {
        static public IEnumerable<SerializedProperty> GetImmediateChildren(this SerializedObject item, bool only_visible)
        {
            using (SerializedProperty property = item.GetIterator())
            {
                if (property.Next(only_visible, true))
                {
                    do
                    {
                        yield return property.Copy();
                    } while (property.Next(only_visible, false));
                }
            }
        }
    }
}