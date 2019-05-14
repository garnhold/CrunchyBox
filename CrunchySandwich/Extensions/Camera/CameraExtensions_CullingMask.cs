using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    static public class CameraExtensions_CullingMask
    {
        static public void SetCullingMask(this Camera item, int mask)
        {
            item.cullingMask = mask;
        }

        static public void AddToCullingMask(this Camera item, int mask)
        {
            item.cullingMask = item.cullingMask.GetBitUnion(mask);
        }

        static public void RemoveFromCullingMask(this Camera item, int mask)
        {
            item.cullingMask = item.cullingMask.GetBitExclusion(mask);
        }
    }
}