﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    public class EditDisplay_Reflected : EditDisplay
    {
        private ReflectedDisplay display;

        public EditDisplay_Reflected(EditTarget t, ReflectedDisplay d) : base(t)
        {
            display = d;
        }

        public override string GetName()
        {
            return display.GetDisplayName();
        }

        public override IEnumerable<object> GetValues()
        {
            return display.GetValues();
        }

        public override bool TryGetValue(out object value)
        {
            return display.TryGetValue(out value);
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return display.GetAllCustomAttributes(inherit);
        }
    }
}