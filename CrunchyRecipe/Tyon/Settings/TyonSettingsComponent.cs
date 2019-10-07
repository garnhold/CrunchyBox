using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonSettingsComponent
    {
        private TyonSettings settings;

        public void SetSettings(TyonSettings s)
        {
            settings = s;
        }

        public TyonSettings GetSettings()
        {
            return settings;
        }
    }
}
