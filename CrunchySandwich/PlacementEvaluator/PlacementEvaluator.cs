using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [AssetClassCategory("Utility")]
    public abstract class PlacementEvaluator : CustomAsset
    {
        public abstract bool IsGameObjectPlacementValid(GameObject game_object);
    }
}