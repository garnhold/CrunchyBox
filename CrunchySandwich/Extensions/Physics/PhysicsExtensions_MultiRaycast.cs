using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public partial class PhysicsExtensions
    {
        static public RaycastHit MultiRaycastGetHit(float max_distance, int layer_mask, IEnumerable<Ray> rays)
        {
            return rays
                .Convert(r => r.CastGetHit(max_distance, layer_mask))
                .Narrow(h => h.DidHit())
                .FindLowestRated(h => h.distance);
        }
        static public RaycastHit MultiRaycastGetHit(float max_distance, int layer_mask, params Ray[] rays)
        {
            return MultiRaycastGetHit(max_distance, layer_mask, (IEnumerable<Ray>)rays);
        }

        static public bool MultiRaycast(float max_distance, int layer_mask, out RaycastHit hit, IEnumerable<Ray> rays)
        {
            hit = MultiRaycastGetHit(max_distance, layer_mask, rays);
            return hit.DidHit();
        }
        static public bool MultiRaycast(float max_distance, int layer_mask, out RaycastHit hit, params Ray[] rays)
        {
            return MultiRaycast(max_distance, layer_mask, out hit, (IEnumerable<Ray>)rays);
        }
    }
}