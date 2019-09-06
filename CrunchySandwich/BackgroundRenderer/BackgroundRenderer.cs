using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    [AddComponentMenu("Rendering/Background Renderer")]
    public class BackgroundRenderer : MonoBehaviour
    {
        [SerializeField]private Bounds bounds;
        [SerializeField]private Vector2 margins;

        [SerializeField]private float orthographic_size;
        [SerializeField]private int maximum_number_chunks;

        [SerializeField]private FilterMode filter_mode;

        [SerializeField]private LayerMask source_mask;
        [SerializeField]private SortingLayerEX destination_layer;

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.cyan.GetWithAlpha(0.01f);
            GizmosExtensions.DrawOutlinedCube(bounds);
        }

        [ContextMenu("Clear")]
        private void Clear()
        {
            this.DestroyChildrenAdvisory();
        }

        [ContextMenu("Render")]
        private void Render()
        {
            Rect rect = bounds.GetPlanar();

            Clear();

            Camera camera = this.AddChild(new GameObject("Camera")).AddComponent<Camera>();

            camera.enabled = false;

            camera.clearFlags = CameraClearFlags.SolidColor;
            camera.backgroundColor = Color.clear;
            camera.cullingMask = source_mask;
            camera.nearClipPlane = -1.0f;

            camera.orthographic = true;
            camera.orthographicSize = orthographic_size;
            camera.aspect = 1.0f;

            int number_chunks = 0;
            Vector2 cell_size = camera.GetOrthographicSize() - margins;

            rect.ProcessOverflownGrid(cell_size, delegate(int x, int y, Rect sub_rect) {
                if (number_chunks < maximum_number_chunks)
                {
                    GameObject cell = this.AddChild(new GameObject("RenderedCell"));

                    cell.SetPlanarPosition(sub_rect.center);
                    camera.SetPlanarPosition(sub_rect.center);

                    Texture2D rendered = camera.RenderToTexture2D(0);
                    MeshFilter mesh_filter = cell.AddComponent<MeshFilter>();
                    MeshRenderer mesh_renderer = cell.AddComponent<MeshRenderer>();

                    rendered.filterMode = filter_mode;

                    mesh_filter.mesh = MeshExtensions.CreateCenterQuad(sub_rect.GetSize() + margins);
                    mesh_renderer.material = MaterialExtensions.CreateUnlitTransparentTextureMaterial(rendered);
                    mesh_renderer.SetSortingLayer(destination_layer);

                    number_chunks++;
                }
            });

            camera.DestroyGameObjectAdvisory();
        }

        private void Start()
        {
            if (this.HasNoChildren())
                Render();
        }
    }
}