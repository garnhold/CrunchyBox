﻿using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonDesignatedVariableProvider : TyonSettingsComponent
    {
        public abstract IEnumerable<Variable> GetDesignatedVariables(Type type);
    }
}