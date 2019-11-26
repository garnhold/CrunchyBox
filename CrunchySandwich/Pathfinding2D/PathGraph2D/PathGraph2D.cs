using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    public abstract class PathGraph2D : MonoBehaviourEX, Graph<PathNode2D>
    {
        [SerializeField]private Vector2 size;
        [SerializeFieldEX][PolymorphicField]private PathGraphInfo2D path_graph_info;

        [SerializeField][HideInInspector]private List<PathNode2D> graph_nodes;

        protected abstract void GenerateInternal(Rect rect);

        protected PathNode2D AddPathNode(Vector2 position, float radius)
        {
            PathNode2D path_node = path_graph_info.CreatePathNode();

            path_node.InitializePathNode(position, radius);
            this.AddChild(path_node);
            graph_nodes.Add(path_node);
            return path_node;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;

            GizmosExtensions.DrawWireCube(GetRect());
        }

        [ContextMenu("Clear")]
        public void Clear()
        {
            graph_nodes.DestroyGameObjectsAdvisory();
            graph_nodes.Clear();

            GetComponentsInChildren<PathNode2D>().DestroyGameObjectsAdvisory();
        }

        [ContextMenu("Generate")]
        public void Generate()
        {
            Clear();

            GenerateInternal(GetRect());
            graph_nodes.Process(n => n.OnAddedToPathGraph());
        }

        public Rect GetRect()
        {
            return RectExtensions.CreateCenterRect(this.GetPlanarPosition(), size);
        }

        public int GetNumberGraphNodes()
        {
            return graph_nodes.Count;
        }

        public IEnumerable<PathNode2D> GetGraphNodes()
        {
            return graph_nodes;
        }
    }
}