using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_CanSetAndGet : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_CanSetAndGet INSTANCE = new Filterer_PropertyInfo_CanSetAndGet();

        private Filterer_PropertyInfo_CanSetAndGet() { }

        public override bool Filter(PropertyInfo item)
        {
            return item.CanSetAndGet();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> CanSetAndGet()
        {
            return Filterer_PropertyInfo_CanSetAndGet.INSTANCE;
        }
    }
}