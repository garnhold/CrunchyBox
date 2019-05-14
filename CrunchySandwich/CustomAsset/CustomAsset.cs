using System;

using UnityEngine;

namespace CrunchySandwich
{
    public abstract class CustomAsset : ScriptableObject
    {
        [SerializeField][HideInInspector]private bool is_show_inline = true;
    }
}