using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class MeshBuilder_Smooth : MeshBuilder
    {
        private List<int> indexs;
        private Palette<Vector3> vertexs;

        public MeshBuilder_Smooth()
        {
            indexs = new List<int>();
            vertexs = new Palette<Vector3>();
        }

        public override void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            int index0, index1, index2;

            if (v0 != v1 && v1 != v2 && v2 != v0)
            {
                vertexs.TryAdd(v0, out index0);
                vertexs.TryAdd(v1, out index1);
                vertexs.TryAdd(v2, out index2);

                indexs.Add(index0);
                indexs.Add(index1);
                indexs.Add(index2);
            }
        }

        public override ICatalog<int> GetIndexs()
        {
            return indexs;
        }

        public override ICatalog<Vector3> GetVertexs()
        {
            return vertexs.GetValues();
        }
    }
}