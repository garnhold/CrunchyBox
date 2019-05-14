using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class BoundsExtensions_Faces
    {
        static public Vector3 GetLeftCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedX(-item.extents.x);
        }
        static public Vector3 GetRightCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedX(item.extents.x);
        }

        static public Vector3 GetBottomCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedY(-item.extents.y);
        }
        static public Vector3 GetTopCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedY(item.extents.y);
        }

        static public Vector3 GetNearCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedZ(-item.extents.z);
        }
        static public Vector3 GetFarCenter(this Bounds item)
        {
            return item.center.GetWithAdjustedZ(item.extents.z);
        }

        static public Bounds GetLeftFace(this Bounds item)
        {
            return new Bounds(item.GetLeftCenter(), item.size.GetWithX(0.0f));
        }
        static public Bounds GetRightFace(this Bounds item)
        {
            return new Bounds(item.GetRightCenter(), item.size.GetWithX(0.0f));
        }

        static public Bounds GetBottomFace(this Bounds item)
        {
            return new Bounds(item.GetBottomCenter(), item.size.GetWithY(0.0f));
        }
        static public Bounds GetTopFace(this Bounds item)
        {
            return new Bounds(item.GetTopCenter(), item.size.GetWithY(0.0f));
        }

        static public Bounds GetNearFace(this Bounds item)
        {
            return new Bounds(item.GetNearCenter(), item.size.GetWithZ(0.0f));
        }
        static public Bounds GetFarFace(this Bounds item)
        {
            return new Bounds(item.GetFarCenter(), item.size.GetWithZ(0.0f));
        }
    }
}