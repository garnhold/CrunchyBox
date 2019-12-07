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
    
    public abstract class WalkerBehaviour2D
    {
        public virtual void Initialize(Vector2 position) { }
        public virtual WalkerBehaviour2D Transition(WalkerBehaviour2D new_behaviour) { return new_behaviour; }

        public virtual bool Update(Vector2 position) { return true; }

        public abstract Vector2 GetDirection(Vector2 position);
    }
}