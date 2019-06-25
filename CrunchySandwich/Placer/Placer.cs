using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

using UnityEngine;

namespace CrunchySandwich
{
    [AssetClassCategory("Utility")]
    public class Placer : CustomAsset
    {
        [SerializeField]private List<PlacementEvaluator> placement_evaluators;

        public virtual void ForcePlaceGameObjectAt(GameObject game_object, Vector3 position)
        {
            game_object.transform.position = position;
        }

        public bool PlaceGameObjectAt(GameObject game_object, Vector3 position, bool handle_destroy)
        {
            ForcePlaceGameObjectAt(game_object, position);

            if (placement_evaluators.AreAll(e => e.IsGameObjectPlacementValid(game_object)))
                return true;
            
            if(handle_destroy)
                game_object.DestroyAdvisory();

            return false;
        }
    }
}