using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
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
