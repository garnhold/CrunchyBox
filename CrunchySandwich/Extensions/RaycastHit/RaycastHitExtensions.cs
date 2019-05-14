using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class RaycastHitExtensions
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