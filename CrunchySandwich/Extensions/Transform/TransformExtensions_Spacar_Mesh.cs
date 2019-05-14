﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class TransformExtensions_Spacar_Mesh
    {
        static public void SetSpacarMeshSize(this Transform item, Vector3 size)
        {
            item.GetComponent<MeshFilter>().SetSize(size);
        }

        static public void SetSpacarMeshBounds(this Transform item, Bounds bounds)
        {
            item.GetComponent<MeshFilter>().SetBounds(bounds);
        }

        static public Vector2 GetSpacarMeshSize(this Transform item)
        {
            return item.GetComponent<MeshFilter>().GetSize();
        }

        static public Bounds GetSpacarMeshBounds(this Transform item)
        {
            return item.GetComponent<MeshFilter>().GetBounds();
        }
    }
}