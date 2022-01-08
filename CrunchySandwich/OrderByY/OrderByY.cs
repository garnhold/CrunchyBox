using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Crunchy.Dough;

    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/OrderByY")]
    public class OrderByY : MonoBehaviour
    {
        [SerializeField]private float multiplier;

        [AttachEditGadget(
            "OffsetPoint",
            new string[] {
            },
            new string[] {
                "parent_point", "GetParentPoint()"
            }
        )]
        [SerializeField] private GameObject parent;
        [SerializeField] private Vector2 offset;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder((int)(this.GetOrderPoint().y * multiplier));
        }

        public Vector2 GetParentPoint()
        {
            return parent.IfNotNull(p => p.GetPlanarPosition(), () => this.GetPlanarPosition());
        }

        public Vector2 GetOrderPoint()
        {
            return this.GetParentPoint() + offset;
        }
    }
}