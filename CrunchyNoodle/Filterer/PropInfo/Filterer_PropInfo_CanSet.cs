using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_CanSet : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_CanSet INSTANCE = new Filterer_PropInfo_CanSet();

        private Filterer_PropInfo_CanSet() { }

        public override bool Filter(PropInfoEX item)
        {
            return item.CanSet();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> CanSet()
        {
            return Filterer_PropInfo_CanSet.INSTANCE;
        }
    }
}