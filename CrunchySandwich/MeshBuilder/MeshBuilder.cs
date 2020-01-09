using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class MeshBuilder
    {
        private List<int> indexs;
        private Palette<Vector3> vertexs;

        public MeshBuilder()
        {
            indexs = new List<int>();
            vertexs = new Palette<Vector3>();
        }

        public void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
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

        public ICatalog<int> GetIndexs()
        {
            return indexs;
        }

        public ICatalog<Vector3> GetVertexs()
        {
            return vertexs.GetValues();
        }
    }
}