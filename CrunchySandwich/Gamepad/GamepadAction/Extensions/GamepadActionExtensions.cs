using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Bread;

    static public class GamepadActionExtensions
    {
        static public void DrawIndicator(this GamepadAction item, Vector2 position, float strength)
        {
            EphemeralSystem.GetInstance()
                .NextEphemeral(item.GetIndicator())
                .Initialize(position, strength);
        }
    }
}