using System;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Sandwich;
    
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