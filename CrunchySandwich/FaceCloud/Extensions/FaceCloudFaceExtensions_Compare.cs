using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class FaceCloudFaceExtensions_Compare
    {
        static public bool IsNotUsed(this FaceCloudFace item)
        {
            if (item.IsUsed() == false)
                return true;

            return false;
        }
    }
}