using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Sandwich;
    
    static public class SpriteExtensions_Annotation
    { 
        [MenuItem("Assets/Sprite/Edit/Annotation")]
        static private void EditSpriteAnnotation()
        {
            ((Sprite)Selection.activeObject).FetchAssetExtension<SpriteAnnotation>().FocusAsset();
        }

        [MenuItem("Assets/Sprite/Edit/Annotation", true)]
        static private bool EditSpriteAnnotationValidate()
        {
            if (Selection.activeObject is Sprite)
                return true;

            return false;
        }
    }
}