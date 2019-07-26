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
    static public class EditorWindowExtensions_Size
    {
        static public Vector2 GetSize(this EditorWindow item)
        {
            return item.position.size;
        }

        static public float GetWidth(this EditorWindow item)
        {
            return item.GetSize().x;
        }

        static public float GetHeight(this EditorWindow item)
        {
            return item.GetSize().y;
        }
    }
}