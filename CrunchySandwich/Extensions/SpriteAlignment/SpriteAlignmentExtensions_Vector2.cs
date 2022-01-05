using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteAlignmentExtensions_Vector2
    {
        static public Vector2 GetVector2(this SpriteAlignment item)
        {
            switch (item)
            {
                case SpriteAlignment.Center: return new Vector2(0.5f, 0.5f);

                case SpriteAlignment.TopLeft: return new Vector2(0.0f, 1.0f);
                case SpriteAlignment.TopCenter: return new Vector2(0.5f, 1.0f);
                case SpriteAlignment.TopRight: return new Vector2(1.0f, 1.0f);

                case SpriteAlignment.LeftCenter: return new Vector2(0.0f, 0.5f);
                case SpriteAlignment.RightCenter: return new Vector2(1.0f, 0.5f);

                case SpriteAlignment.BottomLeft: return new Vector2(0.0f, 0.0f);
                case SpriteAlignment.BottomCenter: return new Vector2(0.5f, 0.0f);
                case SpriteAlignment.BottomRight: return new Vector2(1.0f, 0.0f);

                case SpriteAlignment.Custom: return new Vector2(-10.0f, -10.0f);
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}