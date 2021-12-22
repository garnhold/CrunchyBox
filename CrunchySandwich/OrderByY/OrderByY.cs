using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
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
                "parent_point", "GetPlanarPosition()"
            }
        )]
        [SerializeField] private Vector2 offset;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder((int)(this.GetOrderPoint().y * multiplier));
        }

        public Vector2 GetOrderPoint()
        {
            return this.GetPlanarPosition() + offset;
        }
    }
}