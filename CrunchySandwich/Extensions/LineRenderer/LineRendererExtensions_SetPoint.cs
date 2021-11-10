using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;

using UnityEngine;

namespace Crunchy.Sandwich
{
    static public class LineRendererExtensions_SetPoint
    {
        static public void SetLocalPoint(this LineRenderer item, int index, Vector3 position)
        {
            item.SetPosition(index, position);
        }
        static public void SetWorldPoint(this LineRenderer item, int index, Vector3 position)
        {
            item.SetLocalPoint(index, item.transform.InverseTransformPoint(position));
        }
    }
}