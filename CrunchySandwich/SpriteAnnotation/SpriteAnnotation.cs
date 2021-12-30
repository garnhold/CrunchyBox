using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    public class SpriteAnnotation : AssetExtension
    {
        [SerializeField] private List<LabeledSpritePoint> points;

        private Dictionary<string, LabeledSpritePoint> points_by_label;

        public LabeledSpritePoint GetPoint(string label)
        {
            if (points_by_label == null)
                points_by_label = points.ToDictionaryValues(p => p.GetLabel());

            return points_by_label.GetValue(label);
        }
    }
}