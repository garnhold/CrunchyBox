using System;

using UnityEngine;

namespace CrunchySandwich
{
    static public class Triangle3Extensions_Compare
    {
        static public bool IsDegenerate(this Triangle3 item)
        {
            if (item.v0 == item.v1 || item.v1 == item.v2 || item.v2 == item.v0)
                return true;

            return false;
        }
    }
}