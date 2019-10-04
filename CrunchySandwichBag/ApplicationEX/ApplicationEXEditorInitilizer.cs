using System;

using UnityEngine;
using UnityEditor;

using CrunchySandwich;

namespace CrunchySandwichBag
{
    [EditorInitializer]
    static public class ApplicationEXEditorInitilizer
    {
        [EditorInitializer]
        static private void Initilize()
        {
            ApplicationEX.GetInstance().StartInEditor();

            EditorApplication.update += delegate() {
                ApplicationEX.GetInstance().UpdateInEditor();
            };
        }
    }
}