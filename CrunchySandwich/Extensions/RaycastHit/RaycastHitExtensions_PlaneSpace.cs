using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class RaycastHitExtensions_PlaneSpace
    {
        static public PlaneSpace GetPlaneSpace(this RaycastHit item)
        {
            return item.GetPlane().GetPlaneSpace();
        }
    }
}