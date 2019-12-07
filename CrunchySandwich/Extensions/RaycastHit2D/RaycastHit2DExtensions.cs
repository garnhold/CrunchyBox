using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class RaycastHit2DExtensions
    {
        static public bool DidHit(this RaycastHit2D item)
        {
            if (item.collider != null)
                return true;

            return false;
        }
    }
}