using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class MeshLumper : MonoBehaviour
    {
        [SerializeField]private Vector3 size = new Vector3(100.0f, 100.0f, 100.0f);
        [SerializeField]private Vector2 cell_size = new Vector2(10.0f, 10.0f);
        [SerializeField]private short target_number_vertexs = 2500;

        private void Lump(Material material, List<LumpableMesh> lumpables, GameObject parent)
        {
            GameObject lump = parent.AddChild(new GameObject("Lump"));

            lump.AddComponent<MeshFilter>().mesh = MeshExtensions.CreateCombined(lumpables.Convert(l => l.Lump()));
            lump.AddComponent<MeshRenderer>().sharedMaterial = material;
        }

        private void NarrowAttemptLump(Material material, List<LumpableMesh> lumpables, Rect rect, GameObject parent)
        {
            AttemptLump(
                material,
                lumpables.Narrow(l => rect.Contains(l.GetArearPosition())).ToList(),
                rect,
                parent
            );
        }

        private void AttemptLump(Material material, List<LumpableMesh> lumpables, Rect rect, GameObject parent)
        {
            if (lumpables.Count > 1)
            {
                if(lumpables.Convert(l => l.GetNumberVertexs()).Sum() <= target_number_vertexs)
                    Lump(material, lumpables, parent);
                else
                {
                    Rect r1, r2, r3, r4;

                    rect.SplitIntoQuarters(out r1, out r2, out r3, out r4);

                    NarrowAttemptLump(material, lumpables, r1, parent);
                    NarrowAttemptLump(material, lumpables, r2, parent);
                    NarrowAttemptLump(material, lumpables, r3, parent);
                    NarrowAttemptLump(material, lumpables, r4, parent);
                }
            }
        }

        private void GridLump(Material material, List<LumpableMesh> lumpables, Rect rect, GameObject parent)
        {
            IGrid<List<LumpableMesh>> grid = new Grid<List<LumpableMesh>>(rect.size.GetComponentDivide(cell_size).GetVectorI2());

            foreach(LumpableMesh lumpable in lumpables)
            {
                grid.Add(
                    rect.GetContainingGridIndex(lumpable.GetArearPosition(), cell_size),
                    lumpable
                );
            }

            grid.ProcessWithIndexs(delegate (int x, int y, List<LumpableMesh> list) {
                if (list.IsNotEmpty())
                {
                    AttemptLump(
                        material,
                        list,
                        rect.GetOverflownGridChunk(x, y, cell_size),
                        parent
                    );
                }
            });
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.blue.GetWithAlpha(0.05f);
            GizmosExtensions.DrawOutlinedCube(GetBounds());

            Gizmos.color = Color.black;
            GizmosExtensions.DrawArearGrid(GetRect(), cell_size);
        }

        private void Start()
        {
            Bounds bounds = GetBounds();

            Dictionary<Material, List<LumpableMesh>> lumpables = GameObject.FindObjectsOfType<LumpableMesh>()
                .Narrow(l => bounds.Contains(l.transform.position))
                .ToMultiDictionary(l => l.GetMaterial());

            foreach (KeyValuePair<Material, List<LumpableMesh>> pair in lumpables)
                GridLump(pair.Key, pair.Value, bounds.GetArear(), new GameObject("Lumps"));
        }

        public Bounds GetBounds()
        {
            return new Bounds(transform.position, size);
        }

        public Rect GetRect()
        {
            return GetBounds().GetArear();
        }
    }
}