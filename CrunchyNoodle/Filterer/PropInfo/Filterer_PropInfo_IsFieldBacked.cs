using System;
using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropInfo_IsFieldBacked : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsFieldBacked INSTANCE = new Filterer_PropInfo_IsFieldBacked();

        private Filterer_PropInfo_IsFieldBacked()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsFieldBacked();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsFieldBacked()
        {
            return Filterer_PropInfo_IsFieldBacked.INSTANCE;
        }
    }
}