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
        [SerializeField] private Vector2 offset;

        [SerializeField] private GameObject offset_origin;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder((int)(this.GetOrderPoint().y * multiplier));
        }

        public Vector2 GetParentPoint()
        {
            return offset_origin.IfNotNull(p => p.GetPlanarPosition(), () => this.GetPlanarPosition());
        }

        public Vector2 GetOrderPoint()
        {
            return this.GetParentPoint() + offset;
        }
    }
}