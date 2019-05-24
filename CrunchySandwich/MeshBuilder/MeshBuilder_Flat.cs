using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public class MeshBuilder_Flat : MeshBuilder
    {
        private List<int> indexs;
        private List<Vector3> vertexs;

        public MeshBuilder_Flat()
        {
            indexs = new List<int>();
            vertexs = new List<Vector3>();
        }

        public override void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2)
        {
            if (v0 != v1 && v1 != v2 && v2 != v0)
            {
                vertexs.Add(v0);
                indexs.Add(vertexs.GetFinalIndex());

                vertexs.Add(v1);
                indexs.Add(vertexs.GetFinalIndex());

                vertexs.Add(v2);
                indexs.Add(vertexs.GetFinalIndex());
            }
        }

        public override ICatalog<int> GetIndexs()
        {
            return indexs.AsCatalog();
        }

        public override ICatalog<Vector3> GetVertexs()
        {
            return vertexs.AsCatalog();
        }
    }
}