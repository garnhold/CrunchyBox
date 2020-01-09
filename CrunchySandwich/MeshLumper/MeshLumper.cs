using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class MeshLumper : MonoBehaviour
    {
        [SerializeField]private Vector3 size;
        [SerializeField]private Vector3 cell_size;
        [SerializeField]private short target_number_vertexs;

        private void Lump(Material material, List<LumpableMesh> lumpables, GameObject parent)
        {
            GameObject lump = parent.AddChild(new GameObject("Lump"));

            lump.AddComponent<MeshFilter>().mesh = MeshExtensions.CreateCombined(lumpables.Convert(l => l.Lump()));
            lump.AddComponent<MeshRenderer>().sharedMaterial = material;
        }

        private void NarrowAttemptLump(Material material, List<LumpableMesh> lumpables, Bounds bounds, GameObject parent)
        {
            AttemptLump(
                material,
                lumpables.Narrow(l => bounds.Contains(l.transform.position)).ToList(),
                bounds,
                parent
            );
        }

        private void AttemptLump(Material material, List<LumpableMesh> lumpables, Bounds bounds, GameObject parent)
        {
            if (lumpables.Count > 1)
            {
                if(lumpables.Convert(l => l.GetNumberVertexs()).Sum() <= target_number_vertexs)
                    Lump(material, lumpables, parent);
                else
                {
                    Bounds b1, b2, b3, b4;

                    bounds.SplitIntoAreaQuarters(out b1, out b2, out b3, out b4);

                    NarrowAttemptLump(material, lumpables, b1, parent);
                    NarrowAttemptLump(material, lumpables, b2, parent);
                    NarrowAttemptLump(material, lumpables, b3, parent);
                    NarrowAttemptLump(material, lumpables, b4, parent);
                }
            }
        }

        private void GridLump(Material material, List<LumpableMesh> lumpables, Bounds bounds, GameObject parent)
        {
            Grid<List<LumpableMesh>> grid = new Grid<List<LumpableMesh>>(Mathf.CeilToInt(bounds.size.x / cell_size.x), Mathf.CeilToInt(bounds.size.z / cell_size.z));

            foreach(LumpableMesh lumpable in lumpables)
            {
                Vector2 cell = (lumpable.transform.position - bounds.min).GetComponentDivide(cell_size).GetArear();

                grid.AddData((int)cell.x, (int)cell.y, lumpable);
            }

            foreach (GridCell<List<LumpableMesh>> cell in grid)
            {
                List<LumpableMesh> list = cell.GetData();

                if(list != null)
                {
                    AttemptLump(
                        material,
                        list,
                        bounds.GetOverflownAreaGridChunk(cell.GetX(), cell.GetY(), cell_size),
                        parent
                    );
                }
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue.GetWithAlpha(0.05f);
            GizmosExtensions.DrawOutlinedCube(GetBounds());

            Gizmos.color = Color.red.GetWithAlpha(0.05f);
            GizmosExtensions.DrawOutlinedCube(transform.position, cell_size);
        }

        private void Start()
        {
            Bounds bounds = GetBounds();
            Dictionary<Material, List<LumpableMesh>> lumpables = GameObject.FindObjectsOfType<LumpableMesh>()
                .Narrow(l => bounds.Contains(l.transform.position))
                .ToMultiDictionary(l => l.GetMaterial());

            foreach (KeyValuePair<Material, List<LumpableMesh>> pair in lumpables)
                GridLump(pair.Key, pair.Value, bounds, new GameObject("Lumps"));
        }

        public Bounds GetBounds()
        {
            return new Bounds(transform.position, size);
        }
    }
}