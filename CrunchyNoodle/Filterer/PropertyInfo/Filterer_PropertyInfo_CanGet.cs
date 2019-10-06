using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_CanGet : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_CanGet INSTANCE = new Filterer_PropertyInfo_CanGet();

        private Filterer_PropertyInfo_CanGet() { }

        public override bool Filter(PropertyInfo item)
        {
            return item.CanGet();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> CanGet()
        {
            return Filterer_PropertyInfo_CanGet.INSTANCE;
        }
    }
}