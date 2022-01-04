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
    
    static public class Texture2DExtensions_Shrinkwrap
    {
        static public void Shrinkwrap(this Texture2D item)
        {
            item.GetSprites().Process(s => s.Shrinkwrap());
        }

        [MenuItem("Assets/Sprite/Edit/Shrinkwrap")]
        static private void ShrinkwrapTexture()
        {
            ((Texture2D)Selection.activeObject).Shrinkwrap();
        }

        [MenuItem("Assets/Sprite/Edit/Shrinkwrap", true)]
        static private bool ShrinkwrapTextureValidate()
        {
            if (Selection.activeObject is Texture2D)
                return true;

            return false;
        }
    }
}