using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class SpriteExtensions_Collider
    {
        static public void GenerateSpriteCollider(this Sprite item)
        {
            item.texture.GenerateSpriteCollider(item);
        }

        [MenuItem("Assets/Sprite/Generate Collider")]
        static private void GenerateSpriteCollider()
        {
            ((Sprite)Selection.activeObject).GenerateSpriteCollider();
        }

        [MenuItem("Assets/Sprite/Generate Collider", true)]
        static private bool GenerateSpriteColliderValidate()
        {
            if (Selection.activeObject is Sprite)
                return true;

            return false;
        }
    }
}