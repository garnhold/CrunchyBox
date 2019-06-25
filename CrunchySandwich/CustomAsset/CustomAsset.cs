using System;

using UnityEngine;

namespace CrunchySandwich
{
    [AssetClass]
    public abstract class CustomAsset : ScriptableObject
    {
        [SerializeField][HideInInspector]private bool is_show_inline = true;
    }
}