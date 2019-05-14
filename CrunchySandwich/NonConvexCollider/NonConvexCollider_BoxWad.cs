using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class NonConvexCollider_BoxWad : NonConvexCollider
    {
        [SerializeField]private bool try_combine_boxes;
        [SerializeField]private float tolerance_percent;

        [SerializeField]private bool enforce_minimum_volume;
        [SerializeField]private float minimum_volume;

        [SerializeField]private NonConvexColliderBoxWadFinalizationType finalization_type;

        private List<Bounds> wad_boxes;

        protected abstract void GenerateBoxWadInternal();

        protected void AddWadBox(Bounds bounds)
        {
            wad_boxes.Add(bounds);
        }
        protected void AddWadBox(params Bounds[] bounds)
        {
            AddWadBox(bounds.GetEncompassing());
        }

        protected bool CheckBox(Bounds bounds)
        {
            if (PhysicsExtensions.OverlapBox(bounds).Has(GetMeshCollider()))
                return true;

            return false;
        }

        private void FinalizeAsBoxes()
        {
            foreach (Bounds bounds in wad_boxes)
                AddColliderComponent<BoxCollider>().SetBounds(bounds);
        }

        private void FinalizeAsConvexChunks()
        {
            foreach (Bounds bounds in wad_boxes)
            {
                Mesh mesh = GetMeshDissector().GetChunk(bounds);

                if (mesh.vertexCount >= 3)
                    AddColliderComponent<MeshCollider>().SetConvexHull(mesh);
            }
        }

        protected override void GenerateColliderInternal()
        {
            wad_boxes = new List<Bounds>();

            GenerateBoxWadInternal();

            if (try_combine_boxes)
                wad_boxes.Set(wad_boxes.Combine(tolerance_percent));

            if (enforce_minimum_volume)
                wad_boxes.RemoveAll(b => b.GetVolume() < minimum_volume);

            switch (finalization_type)
            {
                case NonConvexColliderBoxWadFinalizationType.Boxes: FinalizeAsBoxes(); break;
                case NonConvexColliderBoxWadFinalizationType.ConvexChunks: FinalizeAsConvexChunks(); break;
            }
            
            wad_boxes.Clear();
        }
    }
}