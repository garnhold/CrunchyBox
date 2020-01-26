using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    static public class TransformExtensions_Spacar_Scale
    {
        static public void ScaleSpacarScale(this Transform item, float scale)
        {
            item.SetSpacarScale(item.GetSpacarScale() * scale);
        }
        static public void ScaleLocalSpacarScale(this Transform item, float scale)
        {
            item.SetLocalSpacarScale(item.GetLocalSpacarScale() * scale);
        }
    }
}