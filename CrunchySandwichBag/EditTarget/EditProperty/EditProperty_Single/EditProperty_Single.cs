using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public abstract class EditProperty_Single : EditProperty
    {
        public abstract bool TryGetContents(out EditTarget value);
        public abstract bool TryGetContentsType(out Type type);

        public EditProperty_Single(EditTarget t) : base(t)
        {
        }
    }
}