using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [Serializable]
    public class SpritePoint
    {
        [SerializeField]private string label;
        [SerializeField]private Vector2 point;

        public SpritePoint(string l, Vector2 p)
        {
            label = l;
            point = p;
        }

        public string GetLabel()
        {
            return label;
        }

        public Vector2 GetPoint()
        {
            return point;
        }
    }
}