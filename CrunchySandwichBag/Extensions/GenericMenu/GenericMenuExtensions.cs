using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchySandwichBag
{
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