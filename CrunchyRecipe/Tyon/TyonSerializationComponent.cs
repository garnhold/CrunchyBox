using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public abstract class TyonSerializationComponent
    {
        private TyonSerializationSettings settings;

        public void SetSettings(TyonSerializationSettings s)
        {
            settings = s;
        }

        public TyonSerializationSettings GetSettings()
        {
            return settings;
        }
    }
}
