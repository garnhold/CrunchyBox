using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;    
    static public class GenericMenuExtensions
    {
        static public GenericMenu Create<T>(IEnumerable<T> options, Process<T> process)
        {
            GenericMenu menu = new GenericMenu();

            menu.AddItems<T>(options, process);
            return menu;
        }
    }
}