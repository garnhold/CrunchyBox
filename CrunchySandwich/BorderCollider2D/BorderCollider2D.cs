using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [AddComponentMenu("Physics 2D/Border Collider 2D")]
    public class BorderCollider2D : MonoBehaviour
    {
        [SerializeField]private Vector2 size;
        [SerializeField]private Vector2 offset;

        [SerializeField]private float thickness;

        private void OnDrawGizmos()
        {
            Gizmos.matrix = transform.localToWorldMatrix;

            Gizmos.DrawWireCube(offset, size);
            Gizmos.DrawWireCube(offset, size + 2.0f * new Vector2(thickness, thickness));
        }

        private void Start()
        {
            Rect inner_rect = RectExtensions.CreateCenterRect(offset, size);
            Rect outer_rect = inner_rect.GetEnlarged(thickness);

            outer_rect.GetSubtraction(inner_rect).Process(r => this.AddComponent<BoxCollider2D>().SetLocalRect(r));
        }
    }
}