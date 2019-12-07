using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bun;
    
    public class WorldPress
    {
        private int update_id;
        private TapTimer timer;

        private Vector2 initial_press_position;
        private Vector2 current_press_position;

        private bool is_dragging;
        private RelativePoint drag_point;
        private RelativePoint touch_point;
        private IWorldPressTarget world_press_target;

        private WorldPressSystem world_press_system;

        private RelativePoint CreateRelativePointFromWorldPoint(Vector2 world_point)
        {
            if (world_press_target != null)
            {
                return world_press_target.gameObject.transform
                    .CreateRelativePointFromWorldPoint(world_point);
            }

            return RelativePoint.FromPoint(world_point);
        }

        private void UpdatePositionInitial()
        {
            initial_press_position = current_press_position;

            world_press_target =
                Physics2DExtensions.OverlapCircleAll(initial_press_position, world_press_system.GetPressRadius(), world_press_system.GetTargetLayers())
                    .Narrow(c => c.HasComponentUpward<IWorldPressTarget>())
                    .Convert(c => c.gameObject)
                    .FindRolling(
                        new RollingCriteria<GameObject>(RollingCriteriaTarget.Larger, g => g.GetSortingLayer().IfNotNull(l => l.GetValue())),
                        new RollingCriteria<GameObject>(RollingCriteriaTarget.Smaller, g => g.GetPlanarSize().GetMinComponent())
                    )
                    .IfNotNull(z => z.GetComponentUpward<IWorldPressTarget>());

            touch_point = CreateRelativePointFromWorldPoint(GetCurrentPressPosition());
            world_press_target.IfNotNull(t => t.Touch(this));

            timer.Restart();
        }

        private void UpdatePositionSubsequent()
        {
            if (world_press_target != null)
            {
                if (is_dragging)
                    world_press_target.Drag(this);
                else
                {
                    if(current_press_position.IsOutsideDistance(touch_point.GetWorldPoint(), world_press_system.GetDragThreshold()))
                    {
                        world_press_target.Grab(this);

                        drag_point = CreateRelativePointFromWorldPoint(GetCurrentPressPosition());
                        is_dragging = true;
                    }
                }
            }
        }

        private void UpdatePositionFinal()
        {
            if (world_press_target != null)
            {
                if (is_dragging)
                    world_press_target.Drop(this);
                else
                    world_press_target.Tap(this, timer.GetTapType());

                world_press_target.Untouch(this);
            }
        }

        public WorldPress(WorldPressSystem s)
        {
            timer = new TapTimer();

            world_press_system = s;
        }

        public void UpdatePosition(Vector2 position, int id)
        {
            current_press_position = position;

            if (update_id <= 0)
                UpdatePositionInitial();
            else
                UpdatePositionSubsequent();

            update_id = id;
        }

        public bool Update(int id)
        {
            if (update_id == id)
                return true;

            UpdatePositionFinal();
            return false;
        }

        public Vector2 GetInitialPressPosition()
        {
            return initial_press_position;
        }

        public Vector2 GetCurrentPressPosition()
        {
            return current_press_position;
        }

        public Vector2 GetDragPoint()
        {
            return drag_point.GetWorldPoint().GetPlanar();
        }

        public Vector2 GetTargetPosition()
        {
            return current_press_position - drag_point.GetWorldOffset().GetPlanar();
        }

        public Vector2 GetDragOffset()
        {
            return current_press_position - GetDragPoint();
        }

        public WorldPressSystem GetWorldPressSystem()
        {
            return world_press_system;
        }
    }
}