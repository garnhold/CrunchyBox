using System;

using UnityEngine;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Rendering/OrderByY")]
    public class OrderByY : MonoBehaviour
    {
        [SerializeField]private float multiplier;

        private void Update()
        {
            GetComponent<Renderer>().SetSortingOrder((int)(this.GetPlanarPosition().y * multiplier));
        }
    }
}