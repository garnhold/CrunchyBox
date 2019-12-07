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
        public abstract bool TryGetContents(out EditTarget value);
        public abstract bool TryGetContentsType(out Type type);

        public EditProperty_Single(EditTarget t) : base(t)
        {
        }
    }
}