using System;

using UnityEngine;

namespace CrunchySandwich
{
    [CustomAssetCategory("Utility")]
    public abstract class PlacementEvaluator : CustomAsset
    {
        public abstract bool IsGameObjectPlacementValid(GameObject game_object);
    }
}