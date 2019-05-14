﻿using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyRecipe;

namespace CrunchySandwich
{
    [AttributeUsage(AttributeTargets.Field)]
    public class PolymorphicField : Attribute
    {
    }
}