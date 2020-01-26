using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;    
    [ExecuteInEditMode]
    [AddComponentMenu("Pathfinding2D/PathNode2D/PathNode2D_BlockableStatic")]
    public class PathNode2D_BlockableStatic : PathNode2D
    {
        [SerializeField]private float check_interval;

        [SerializeField][HideInInspector]private List<PathNode2D> connections;

        private PeriodicWorkScheduler scheduler;
        private List<PathNode2D> current_connections;

        public override void OnAddedToPathGraph()
        {
            connections = CalculatePotentialConnections().ToList();
        }

        private void Awake()
        {
            Debug.Log("Awa Check " + check_interval);
            scheduler = new PeriodicWorkScheduler(
                this,
                () => Duration.Seconds(check_interval),
                () => UpdateConnections()
            );
            current_connections = new List<PathNode2D>();
        }

        private void Start()
        {
            Debug.Log("start Check " + check_interval);
            scheduler = new PeriodicWorkScheduler(
                this,
                () => Duration.Seconds(check_interval),
                () => UpdateConnections()
            );
            current_connections = new List<PathNode2D>();

            UpdateConnections();
        }

        public PathNode2D_BlockableStatic()
        {
            Debug.Log("ContCheck " + check_interval);
            scheduler = new PeriodicWorkScheduler(
                this,
                () => Duration.Seconds(check_interval),
                () => UpdateConnections()
            );
            current_connections = new List<PathNode2D>();
        }

        public void InitializePathNodeBlockableStatic(float c)
        {
            check_interval = c;
        }

        public void UpdateConnections()
        {
            current_connections.Set(
                connections
                    .Narrow(n => n.IsConnection(this))
                    .ToList()
            );
        }

        public override IEnumerable<PathNode2D> GetConnections()
        {
            scheduler.Update();

            return current_connections;
        }
    }
}