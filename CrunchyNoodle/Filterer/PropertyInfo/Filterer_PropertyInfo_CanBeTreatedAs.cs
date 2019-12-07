using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    public class Filterer_PropertyInfo_CanBeTreatedAs<T> : Filterer_PropertyInfo_CanBeTreatedAs
    {
        static public readonly Filterer_PropertyInfo_CanBeTreatedAs<T> INSTANCE = new Filterer_PropertyInfo_CanBeTreatedAs<T>();

        private Filterer_PropertyInfo_CanBeTreatedAs() : base(typeof(T)) { }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> CanBeTreatedAs<T>()
        {
            return Filterer_PropertyInfo_CanBeTreatedAs<T>.INSTANCE;
        }
    }

    public class Filterer_PropertyInfo_CanBeTreatedAs : Filterer_General<PropertyInfo, IdentifiableType>
    {
        public Filterer_PropertyInfo_CanBeTreatedAs(Type t) : base(t) { }

        public override bool Filter(PropertyInfo item)
        {
            if (item.PropertyType.CanBeTreatedAs(GetId()))
                return true;

            return false;
        }
    }
    static public partial class Filterer_PropertyInfo
    {
        static public Filterer<PropertyInfo> CanBeTreatedAs(Type type)
        {
            return new Filterer_PropertyInfo_CanBeTreatedAs(type);
        }
    }
}