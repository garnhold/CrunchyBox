using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;
    
    [AssetClassCategory("Input")]
    public abstract class GamepadAction : CustomAsset
    {
        [SerializeField]private string title;
        [SerializeField]private string command;

        [SerializeField]private Indicator indicator;

        public abstract bool IsOccuringThisFrame(GamepadBase gamepad);
        public abstract IEnumerable<GamepadComponentId> GetComponentIds();

        public string GetTitle()
        {
            return title;
        }

        public string GetCommand()
        {
            return command;
        }

        public Indicator GetIndicator()
        {
            return indicator;
        }
    }
}