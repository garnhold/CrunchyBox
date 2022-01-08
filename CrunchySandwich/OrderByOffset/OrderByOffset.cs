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
        [SerializeField] private GameObject parent;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder(GetParentOrder() + offset);
        }

        public int GetParentOrder()
        {
            return parent.IfNotNull(p => p.GetComponent<Renderer>().GetSortingOrder(), 0);
        }
    }
}