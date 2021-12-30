using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;

    [Serializable]
    public struct LabeledSpritePoint
    {
        [SerializeField] private string label;
        [SerializeField] private Vector2 position;

        public LabeledSpritePoint(string l, Vector2 p)
        {
            label = l;
            position = p;
        }

        public string GetLabel()
        {
            return label;
        }

        public Vector2 GetPosition()
        {
            return position;
        }
    }
}