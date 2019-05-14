using System;

using UnityEngine;
using UnityEditor;

using CrunchySandwich;

namespace CrunchySandwichBag
{
    [InitializeOnLoad]
    static public class ApplicationEXEditorInitilizer
    {
        static private void Initilize()
        {
            ApplicationEX.GetInstance().Start();

            EditorApplication.update += delegate() {
                ApplicationEX.GetInstance().Update();
            };
        }

        static ApplicationEXEditorInitilizer()
        {
            Initilize();
        }
    }
}