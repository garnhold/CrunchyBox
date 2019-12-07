using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    
    static public class GenericMenuExtensions_Add
    {
        static public void AddItem(this GenericMenu item, string text, Process process)
        {
            item.AddItem(new GUIContent(text), false, () => process());
        }

        static public void AddItem<T>(this GenericMenu item, T option, Process<T> process)
        {
            item.AddItem(option.ToStringEX("None"), () => process(option));
        }

        static public void AddItems<T>(this GenericMenu item, IEnumerable<T> options, Process<T> process)
        {
            options.Process(o => item.AddItem<T>(o, process));
        }
    }
}