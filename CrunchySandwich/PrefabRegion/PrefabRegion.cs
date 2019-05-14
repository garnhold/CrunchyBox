using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class PrefabRegion : MonoBehaviour
    {
        [SerializeField]private Vector3 size;

        [SerializeField]private bool auto_populate;
        [SerializeField]private float prefab_density;
        [SerializeField]private PrefabSpawner prefab_spawner;

        protected abstract void PopulateRegionInternal(float density);
        protected virtual void OnDrawGizmosInternal() { }

        protected void SpawnPrefab(Vector3 position)
        {
            gameObject.AddChild(prefab_spawner.SpawnPrefabAt(position));
        }

        private void OnValidate()
        {
            if (auto_populate)
                PopulateRegion();
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.green.GetWithAlpha(0.01f);
            GizmosExtensions.DrawOutlinedCube(GetBounds());

            OnDrawGizmosInternal();
        }

        [ContextMenu("Populate Region")]
        public void PopulateRegion()
        {
            ClearRegion();
            PopulateRegionInternal(prefab_density);
        }

        [ContextMenu("Clear Region")]
        public void ClearRegion()
        {
            gameObject.DestroyChildrenAdvisory();
        }

        public Vector3 GetSize()
        {
            return size;
        }

        public Bounds GetBounds()
        {
            return new Bounds(transform.position, size);
        }
    }
}