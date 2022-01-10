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
        [SerializeField]private GameObject offset_origin;

        private ComponentCache_UpwardFromParent<Renderer> upward_renderer;

        private void Start()
        {
            upward_renderer = new ComponentCache_UpwardFromParent<Renderer>(this);
        }

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder(GetParentOrder() + offset);
        }

        public int GetParentOrder()
        {
            return offset_origin.IfNotNull(
                p => p.GetComponent<Renderer>().GetSortingOrder(),
                () => upward_renderer.Use(r => r.GetSortingOrder())
            );
        }
    }
}