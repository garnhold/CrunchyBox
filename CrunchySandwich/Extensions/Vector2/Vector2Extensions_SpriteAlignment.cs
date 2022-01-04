using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class Vector2Extensions_SpriteAlignment
    {
        static public SpriteAlignment GetSpriteAlignment(this Vector2 item)
        {
            SpriteAlignment alignment;

            if (typeof(SpriteAlignment)
                .GetEnumValues<SpriteAlignment>()
                .TryFindFirst(a => a.GetVector2() == item, out alignment))
                return alignment;

            return SpriteAlignment.Custom;
        }
    }
}