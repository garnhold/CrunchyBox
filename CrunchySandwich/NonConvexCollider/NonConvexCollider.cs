using System;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class NonConvexCollider : MonoBehaviour
    {
        [SerializeField]private Mesh mesh;

        [SerializeField][HideInInspector]private GameObject collider_game_object;

        private MeshCollider mesh_collider;
        private MeshDissector mesh_dissector;

        protected abstract void GenerateColliderInternal();

        protected T AddColliderComponent<T>() where T : Component
        {
            return collider_game_object.AddComponent<T>();
        }

        protected MeshCollider GetMeshCollider()
        {
            return mesh_collider;
        }

        protected MeshDissector GetMeshDissector()
        {
            return mesh_dissector;
        }

        [ContextMenu("Generate Collider")]
        public void GenerateCollider()
        {
            GameObject mesh_game_object = new GameObject();

            mesh_game_object.SetSpacarPosition(this.GetSpacarPosition());
            mesh_collider = mesh_game_object.AddComponent<MeshCollider>();
            mesh_collider.sharedMesh = mesh;

            mesh_dissector = mesh.CreateMeshDissector();

            collider_game_object.IfNotNull(z => z.DestroyAdvisory());
            collider_game_object = this.AddChildAtSelf(new GameObject("Colliders"));

            GenerateColliderInternal();
            mesh_game_object.DestroyAdvisory();
        }
    }
}