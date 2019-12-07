using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    static public class TransformExtensions_Spacar_Match
    {
        static public void MatchSpacarTransform(this Transform item, Transform target)
        {
            item.SetSpacarPosition(target.GetSpacarPosition());
            item.SetSpacarRotation(target.GetSpacarRotation());
            item.SetSpacarScale(target.GetSpacarScale());
        }
    }
}