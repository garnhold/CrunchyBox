using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    public class Placer_OnFloor_Offset : Placer_OnFloor
    {
        [SerializeField]private Vector3 offset;

        protected override void ForcePlaceGameObjectOnFloor(GameObject game_object, RaycastHit hit)
        {
            game_object.transform.SetSpacarPosition(hit.point + offset);
        }
    }
}