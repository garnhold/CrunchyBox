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
    
    public class WalkerBehaviour2D_Towards : WalkerBehaviour2D
    {
        private Vector2 destination;

        public WalkerBehaviour2D_Towards(Vector2 d)
        {
            destination = d;
        }

        public override Vector2 GetDirection(Vector2 position)
        {
            return position.GetDirection(destination);
        }
    }

    static public class Walker2DExtensions_Behaviour_Towards
    {
        static public void SetTowards(this Walker2D item, Vector2 position)
        {
            item.SetBehaviour(new WalkerBehaviour2D_Towards(position));
        }
    }
}