using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [RequireComponent(typeof(PolygonCollider2D))]
    [AddComponentMenu("Physics 2D/Mesh Bisection Collider 2D")]
    public class MeshBisectionCollider2D : MonoBehaviour
    {
        [SerializeField]private Mesh mesh;
        
        

        
        private int last_generate_complete_paths_content_identity;
        private float last_generate_complete_paths_alpha_threshold;

        public void UpdateGeometry()
        {
        }

        public void SetMeshAutomatically()
        {
            mesh = GetComponent<MeshFilter>().IfNotNull(f => f.sharedMesh);
        }
    }
}