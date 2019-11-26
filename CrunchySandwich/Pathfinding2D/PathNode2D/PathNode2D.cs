using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyBun;

namespace CrunchySandwich
{
    [ExecuteInEditMode]
    [AddComponentMenu("Pathfinding2D/PathNode2D")]
    public abstract class PathNode2D : MonoBehaviour, GraphNode_AngleAware_Degrees<PathNode2D>
    {
        [SerializeField]private float radius;

        public virtual void OnAddedToPathGraph() { }
        public abstract IEnumerable<PathNode2D> GetConnections();

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            GetConnections().Process(n => Gizmos.DrawLine(this.GetPlanarPosition(), n.GetPlanarPosition()));
        }

        private void InitializePathNode()
        {
            this.SetLayer(Pathfinding2D.GetInstance().GetNodeLayer());
        }
        private void Update()
        {
            if (Application.isPlaying == false)
                InitializePathNode();
        }

        public void InitializePathNode(Vector2 p, float r)
        {
            radius = r;

            this.SetPlanarPosition(p);
            this.FetchComponent<CircleCollider2D>().radius = radius;

            InitializePathNode();
        }

        public float GetRadius()
        {
            return radius;
        }

        public bool IsConnection(Vector2 position)
        {
            return Pathfinding2D.GetInstance().IsConnection(this, position);
        }

        public bool IsPotentialConnection(Vector2 position)
        {
            return Pathfinding2D.GetInstance().IsPotentialConnection(this, position);
        }

        public IEnumerable<PathNode2D> CalculatePathNodes()
        {
            return Pathfinding2D.GetInstance().GetPathNodes(this.GetPlanarPosition(), radius)
                .Skip(this);
        }

        public IEnumerable<PathNode2D> CalculateConnections()
        {
            return Pathfinding2D.GetInstance().GetConnections(this.GetPlanarPosition(), radius)
                .Skip(this);
        }

        public IEnumerable<PathNode2D> CalculatePotentialConnections()
        {
            return Pathfinding2D.GetInstance().GetPotentialConnections(this.GetPlanarPosition(), radius)
                .Skip(this);
        }

        public float GetAngleInDegreesToGraphNode(PathNode2D node)
        {
            return this.GetPlanarAngleInDegreesBetween(node);
        }
        public double GetDistanceToGraphNode(PathNode2D node)
        {
            return this.GetPlanarDistanceBetween(node);
        }
        public double CalculateHeuristicCostEstimate(PathNode2D node)
        {
            return this.GetPlanarDistanceBetween(node);
        }
        public IEnumerable<PathNode2D> GetConnectedGraphNodes()
        {
            return GetConnections();
        }
    }
}