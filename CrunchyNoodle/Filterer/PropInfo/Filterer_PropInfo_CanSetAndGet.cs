using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_CanSetAndGet : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_CanSetAndGet INSTANCE = new Filterer_PropInfo_CanSetAndGet();

        private Filterer_PropInfo_CanSetAndGet() { }

        public override bool Filter(PropInfoEX item)
        {
            return item.CanSetAndGet();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> CanSetAndGet()
        {
            return Filterer_PropInfo_CanSetAndGet.INSTANCE;
        }
    }
}