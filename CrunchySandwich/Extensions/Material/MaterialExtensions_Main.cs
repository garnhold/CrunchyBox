using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public partial class MaterialExtensions
    {
        static public void SetMainTexture(this Material item, Texture texture)
        {
            item.SetTexture("_MainTex", texture);
        }

        static public void SetMainColor(this Material item, Color color)
        {
            item.SetColor("_Color", color);
        }
    }
}