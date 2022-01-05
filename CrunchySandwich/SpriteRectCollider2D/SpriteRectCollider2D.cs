using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [ExecuteInEditMode]
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(BoxCollider2D))]
    [AddComponentMenu("Physics 2D/Sprite Rect Collider 2D")]
    public class SpriteRectCollider2D : MonoBehaviour
    {
        private void Update()
        {
            this.GetComponent<BoxCollider2D>().SetWorldRect(
                this.GetComponent<SpriteRenderer>().bounds.GetPlanar()
            );
        }
    }
}