using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class WalkerBehaviour2D_Destination : WalkerBehaviour2D
    {
        private Vector2 destination;

        private PathNavigator2D navigator;

        public WalkerBehaviour2D_Destination(Vector2 d)
        {
            destination = d;
        }

        public override void Initialize(Vector2 position)
        {
            navigator = Pathfinding2D.GetInstance().GetPathNavigatorToDestination(
                position,
                destination
            );
        }

        public override WalkerBehaviour2D Transition(WalkerBehaviour2D new_behaviour)
        {
            WalkerBehaviour2D_Destination cast;

            if (new_behaviour.Convert(out cast))
            {
                if (navigator.IfNotNull(n => n.TryAlterDestination(cast.GetDestination())))
                    return this;
            }

            return new_behaviour;
        }

        public override bool Update(Vector2 position)
        {
            return navigator.IfNotNull(n => n.Update(position));
        }

        public override Vector2 GetDirection(Vector2 position)
        {
            if (navigator != null)
                return position.GetDirection(navigator.GetCurrentTargetPosition());

            return Vector2.zero;
        }

        public Vector2 GetDestination()
        {
            return destination;
        }
    }

    static public class Walker2DExtensions_Behaviour_Destination
    {
        static public void SetDestination(this Walker2D item, Vector2 position)
        {
            item.SetBehaviour(new WalkerBehaviour2D_Destination(position));
        }
    }
}