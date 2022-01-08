using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Crunchy.Dough;

    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/OrderByOffset")]
    public class OrderByOffset : MonoBehaviour
    {
        [SerializeField]private int offset;
        [SerializeField] private GameObject offset_origin;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder(GetParentOrder() + offset);
        }

        public int GetParentOrder()
        {
            return offset_origin.IfNotNull(
                p => p.GetComponent<Renderer>().GetSortingOrder(),
                () => this.GetComponentValueUpwardFromParent<Renderer, int>(r => r.GetSortingOrder())
            );
        }
    }
}