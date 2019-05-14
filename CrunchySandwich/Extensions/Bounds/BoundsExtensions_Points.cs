using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace CrunchySandwich
{
    static public class BoundsExtensions_Points
    {
        static public IEnumerable<Vector3> GetPoints(this Bounds item)
        {
            yield return item.GetMinXMinYMinZ();
            yield return item.GetMinXMinYMaxZ();
            yield return item.GetMaxXMinYMinZ();
            yield return item.GetMaxXMinYMaxZ();

            yield return item.GetMinXMaxYMinZ();
            yield return item.GetMinXMaxYMaxZ();
            yield return item.GetMaxXMaxYMinZ();
            yield return item.GetMaxXMaxYMaxZ();
        }

        static public IEnumerable<Vector3> GetLeftFacePoints(this Bounds item)
        {
            yield return item.GetMinXMinYMaxZ();
            yield return item.GetMinXMinYMinZ();
            yield return item.GetMinXMaxYMinZ();
            yield return item.GetMinXMaxYMaxZ();
        }
        static public IEnumerable<Vector3> GetRightFacePoints(this Bounds item)
        {
            yield return item.GetMaxXMinYMinZ();
            yield return item.GetMaxXMinYMaxZ();
            yield return item.GetMaxXMaxYMaxZ();
            yield return item.GetMaxXMaxYMinZ();
        }

        static public IEnumerable<Vector3> GetBottomFacePoints(this Bounds item)
        {
            yield return item.GetMinXMinYMaxZ();
            yield return item.GetMaxXMinYMaxZ();
            yield return item.GetMaxXMinYMinZ();
            yield return item.GetMinXMinYMinZ();
        }
        static public IEnumerable<Vector3> GetTopFacePoints(this Bounds item)
        {
            yield return item.GetMinXMaxYMinZ();
            yield return item.GetMaxXMaxYMinZ();
            yield return item.GetMaxXMaxYMaxZ();
            yield return item.GetMinXMaxYMaxZ();
        }

        static public IEnumerable<Vector3> GetNearFacePoints(this Bounds item)
        {
            yield return item.GetMinXMinYMinZ();
            yield return item.GetMaxXMinYMinZ();
            yield return item.GetMaxXMaxYMinZ();
            yield return item.GetMinXMaxYMinZ();
        }
        static public IEnumerable<Vector3> GetFarFacePoints(this Bounds item)
        {
            yield return item.GetMaxXMinYMaxZ();
            yield return item.GetMinXMinYMaxZ();
            yield return item.GetMinXMaxYMaxZ();
            yield return item.GetMaxXMaxYMaxZ();
        }

        static public Vector3 GetMinXMinYMinZ(this Bounds item)
        {
            return new Vector3(item.min.x, item.min.y, item.min.z);
        }
        static public Vector3 GetMinXMinYMaxZ(this Bounds item)
        {
            return new Vector3(item.min.x, item.min.y, item.max.z);
        }
        static public Vector3 GetMaxXMinYMinZ(this Bounds item)
        {
            return new Vector3(item.max.x, item.min.y, item.min.z);
        }
        static public Vector3 GetMaxXMinYMaxZ(this Bounds item)
        {
            return new Vector3(item.max.x, item.min.y, item.max.z);
        }

        static public Vector3 GetMinXMaxYMinZ(this Bounds item)
        {
            return new Vector3(item.min.x, item.max.y, item.min.z);
        }
        static public Vector3 GetMinXMaxYMaxZ(this Bounds item)
        {
            return new Vector3(item.min.x, item.max.y, item.max.z);
        }
        static public Vector3 GetMaxXMaxYMinZ(this Bounds item)
        {
            return new Vector3(item.max.x, item.max.y, item.min.z);
        }
        static public Vector3 GetMaxXMaxYMaxZ(this Bounds item)
        {
            return new Vector3(item.max.x, item.max.y, item.max.z);
        }
    }
}