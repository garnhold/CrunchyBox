using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_IsUnassociatedMethodsBacked : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsUnassociatedMethodsBacked INSTANCE = new Filterer_PropInfo_IsUnassociatedMethodsBacked();

        private Filterer_PropInfo_IsUnassociatedMethodsBacked()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsUnassociatedMethodsBacked();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsUnassociatedMethodsBacked()
        {
            return Filterer_PropInfo_IsUnassociatedMethodsBacked.INSTANCE;
        }
    }
}