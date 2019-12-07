using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropInfo_IsGetPublic : Filterer_Simple<PropInfoEX>
    {
        static public readonly Filterer_PropInfo_IsGetPublic INSTANCE = new Filterer_PropInfo_IsGetPublic();

        private Filterer_PropInfo_IsGetPublic()
        {
        }

        public override bool Filter(PropInfoEX item)
        {
            return item.IsGetPublic();
        }
    }
    static public partial class Filterer_PropInfo
    {
        static public Filterer<PropInfoEX> IsGetPublic()
        {
            return Filterer_PropInfo_IsGetPublic.INSTANCE;
        }
    }
}