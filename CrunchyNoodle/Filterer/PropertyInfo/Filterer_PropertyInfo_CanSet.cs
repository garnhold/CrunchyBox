using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    public class Filterer_PropertyInfo_CanSet : Filterer_Simple<PropertyInfo>
    {
        static public readonly Filterer_PropertyInfo_CanSet INSTANCE = new Filterer_PropertyInfo_CanSet();

        private Filterer_PropertyInfo_CanSet() { }

        public override bool Filter(PropertyInfo item)
        {
            return item.CanSet();
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> CanSet()
        {
            return Filterer_PropertyInfo_CanSet.INSTANCE;
        }
    }
}