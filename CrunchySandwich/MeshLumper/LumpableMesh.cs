using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [RequireComponent(typeof(MeshFilter))]
    [RequireComponent(typeof(MeshRenderer))]
    public class LumpableMesh : MonoBehaviour
    {
        public CombineInstance Lump()
        {
            CombineInstance combine_instance = new CombineInstance();

            combine_instance.mesh = GetComponent<MeshFilter>().sharedMesh;
            combine_instance.transform = transform.localToWorldMatrix;

            GetComponent<MeshRenderer>().enabled = false;
            return combine_instance;
        }

        public Mesh GetMesh()
        {
            return GetComponent<MeshFilter>().sharedMesh;
        }

        public int GetNumberVertexs()
        {
            return GetMesh().vertexCount;
        }

        public Material GetMaterial()
        {
            return GetComponent<MeshRenderer>().sharedMaterial;
        }
    }
}