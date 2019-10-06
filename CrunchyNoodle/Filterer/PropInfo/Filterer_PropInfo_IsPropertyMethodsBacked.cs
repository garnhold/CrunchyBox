using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_IsPropertyMethodsBacked : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsPropertyMethodsBacked INSTANCE = new Filterer_PropInfo_IsPropertyMethodsBacked();

        private Filterer_PropInfo_IsPropertyMethodsBacked()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsPropertyMethodsBacked();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsPropertyMethodsBacked()
        {
            return Filterer_PropInfo_IsPropertyMethodsBacked.INSTANCE;
        }
    }
}