using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_EvtInfo
    {
        static private OperationCache<EvtInfoEX, Type, string> GET_INSTANCE_EVT = ReflectionCache.Get().NewOperationCache(delegate(Type item, string name) {
            return item.GetInstanceEventEvt(name);
        });
        static public EvtInfoEX GetInstanceEvt(this Type item, string name)
        {
            return GET_INSTANCE_EVT.Fetch(item, name);
        }
    }
}