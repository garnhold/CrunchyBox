using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [RequireComponent(typeof(SpriteRenderer))]
    public class SpriteEXRenderer : MonoBehaviour
    {
        [SerializeField]private SpriteEX sprite;

        public IEnumerable<Vector2> GetLocalPoints(string label)
        {
            return sprite.GetWorldPoints(label);
        }

        public IEnumerable<Vector3> GetWorldPoints(string label)
        {
            return GetLocalPoints(label).Convert(p => transform.TransformPoint(p));fads
        }
    }
}