using System;

using UnityEngine;

namespace CrunchySandwich
{
    [AssetClassCategory("Utility")]
    public abstract class PlacementEvaluator : CustomAsset
    {
        public abstract bool IsGameObjectPlacementValid(GameObject game_object);
    }
}