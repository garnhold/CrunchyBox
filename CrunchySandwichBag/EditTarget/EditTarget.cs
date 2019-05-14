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
    public abstract class EditTarget
    {
        public abstract Type GetTargetType();

        public abstract EditAction ForceAction(string path);
        public abstract EditProperty ForceProperty(string path);

        public abstract IEnumerable<EditAction> GetActions();
        public abstract IEnumerable<EditProperty> GetPropertys();
        public abstract IEnumerable<EditGadget> GetGadgets();
    }
}