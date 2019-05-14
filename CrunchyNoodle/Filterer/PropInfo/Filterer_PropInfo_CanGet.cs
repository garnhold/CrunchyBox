using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_CanGet : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_CanGet INSTANCE = new Filterer_PropInfo_CanGet();

        private Filterer_PropInfo_CanGet() { }

        public override bool Filter(PropInfoEX item)
        {
            return item.CanGet();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> CanGet()
        {
            return Filterer_PropInfo_CanGet.INSTANCE;
        }
    }
}