using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    static public class SpriteExtensions_Annotation
    {
        static public SpriteAnnotation GetSpriteAnnotation(this Sprite item)
        {
            return AssetExtensionManager.GetInstance().GetAssetExtension<SpriteAnnotation>(item);
        }

        static public LabeledSpritePoint GetLabeledSpritePoint(this Sprite item, string label)
        {
            return item.GetSpriteAnnotation().IfNotNull(a => a.GetPoint(label));
        }

        static public Vector2 GetLabeledLocalPoint(this Sprite item, string label)
        {
            return item.TransformNormalizedPoint(
                item.GetLabeledSpritePoint(label)
                    .IfNotNull(p => p.GetPosition())
            );
        }
    }
}