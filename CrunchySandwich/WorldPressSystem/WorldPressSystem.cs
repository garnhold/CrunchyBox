using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    [RequireComponent(typeof(Camera))]
    public class WorldPressSystem : MonoBehaviour
    {
        [SerializeField]private float press_radius;
        [SerializeField]private float drag_threshold;
        [SerializeField]private LayerMask target_layers;

        private int update_id;
        private Dictionary<int, WorldPress> world_presses;

        private void Start()
        {
            update_id = 0;
            world_presses = new Dictionary<int, WorldPress>();
        }
        
        private void Update()
        {
            Camera camera = GetComponent<Camera>();

            foreach(ScreenTouch screen_touch in ScreenInput.GetScreenTouchs())
            {
                world_presses.GetOrCreateValue(screen_touch.id, () => new WorldPress(this))
                    .UpdatePosition(camera.ScreenToWorldPlanarPoint(screen_touch.position), update_id);
            }

            world_presses.Reduce(p => p.Value.Update(update_id));
            update_id++;
        }

        public float GetPressRadius()
        {
            return press_radius;
        }

        public float GetDragThreshold()
        {
            return drag_threshold;
        }

        public LayerMask GetTargetLayers()
        {
            return target_layers;
        }
    }
}