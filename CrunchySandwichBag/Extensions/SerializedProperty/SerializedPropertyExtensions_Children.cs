using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;    
    static public class SerializedPropertyExtensions_Children
    {
        static public IEnumerable<SerializedProperty> GetImmediateChildren(this SerializedProperty item, bool only_visible)
        {
            SerializedProperty property = item.Copy();
            SerializedProperty terminal_property = item.Copy();

            bool has_terminal_property = terminal_property.Next(only_visible, false);

            if (property.Next(only_visible, true))
            {
                do
                {
                    if (has_terminal_property)
                    {
                        if (property.AreSerializedPropertysEqual(terminal_property))
                            yield break;
                    }

                    yield return property.Copy();
                } while (property.Next(only_visible, false));
            }
        }
    }
}