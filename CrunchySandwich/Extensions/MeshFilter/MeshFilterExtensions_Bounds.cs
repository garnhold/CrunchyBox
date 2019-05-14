using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    static public class MeshFilterExtensions_Bounds
    {
        static public void SetBounds(this MeshFilter item, Bounds bounds)
        {
            item.SetSize(bounds.size);
            item.SetSpacarPosition(bounds.center);
        }

        static public Bounds GetBounds(this MeshFilter item)
        {
            return new Bounds(item.GetSpacarPosition(), item.GetSize());
        }
    }
}