using System;

using UnityEngine;

namespace Crunchy.Sandwich
{
    [AssetClass]
    public abstract class CustomAsset : ScriptableObjectEX
    {
        [SerializeField][HideInInspector]private bool is_show_inline = true;
    }
}