using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Noodle;
    using Bun;
    using Sandwich;
    
    public abstract class EditProperty_Single : EditProperty
    {
        public EditProperty_Single(EditTarget t, Variable v) : base(t, v)
        {
        }

        public bool TryGetContents(out EditTarget value)
        {
            value = new EditTarget(GetAllContents(), GetTarget());

            if (value.IsValid())
                return true;

            return false;
        }
    }
}