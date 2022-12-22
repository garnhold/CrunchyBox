using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class RaycastHitExtensions_Hit
    {
        static public bool DidHit(this RaycastHit item)
        {
            if (item.collider != null)
                return true;

            return false;
        }

        static public bool DidNotHit(this RaycastHit item)
        {
            if (item.DidHit() == false)
                return true;

            return false;
        }
    }
}