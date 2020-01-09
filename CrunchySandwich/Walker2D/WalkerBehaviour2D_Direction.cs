using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    using Noodle;
    using Recipe;
    
    public class WalkerBehaviour2D_Direction : WalkerBehaviour2D
    {
        private Vector2 direction;

        public WalkerBehaviour2D_Direction(Vector2 d)
        {
            direction = d;
        }

        public override Vector2 GetDirection(Vector2 position)
        {
            return direction;
        }
    }

    static public class Walker2DExtensions_Behaviour_Direction
    {
        static public void SetDirection(this Walker2D item, Vector2 direction)
        {
            item.SetBehaviour(new WalkerBehaviour2D_Direction(direction));
        }
    }
}