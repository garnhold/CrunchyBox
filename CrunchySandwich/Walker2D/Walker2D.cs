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
    
    public class Walker2D : MonoBehaviourEX
    {
        private WalkerBehaviour2D behaviour;
        private WalkerBehaviour2D queued_behaviour;

        private bool is_moving;

        private PeriodicWorkScheduler update_scheduler;
        private ComponentCache_Downward<Collider2D> collider;

        private void Start()
        {
            update_scheduler = new PeriodicWorkScheduler(
                this,
                () => WalkerSystem2D.GetInstance().GetUpdateInterval(),
                delegate () {
                    if (behaviour != queued_behaviour)
                    {
                        behaviour = behaviour.TransitionStart(
                            behaviour.IfNotNull(b => b.Transition(queued_behaviour), queued_behaviour),
                            b => b.Initialize(GetPosition())
                        );

                        queued_behaviour = behaviour;
                    }

                    is_moving = behaviour.IfNotNull(b => b.Update(GetPosition()));
                }
            );

            collider = new ComponentCache_Downward<Collider2D>(this);
        }

        private void Update()
        {
            update_scheduler.Update();
        }

        public void SetBehaviour(WalkerBehaviour2D new_behaviour)
        {
            queued_behaviour = new_behaviour;

            is_moving = true;
        }

        public bool IsMoving()
        {
            return is_moving;
        }

        public Vector2 GetPosition()
        {
            return collider.GetComponent().GetCenter();
        }

        public Vector2 GetDirection()
        {
            return behaviour.IfNotNull(b => b.GetDirection(GetPosition()));
        }
    }
}