using System;
using System.Reflection;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class TypeExtensions_EvtInfo_Event
    {
        static private OperationCache<EvtInfoEX, Type, string> GET_INSTANCE_EVENT_EVT = ReflectionCache.Get().NewOperationCache("GET_INSTANCE_EVENT_EVT", delegate(Type item, string name) {
            return item.GetInstanceMethodEvtInternal(
                name.GetEntityEventAddMethodName(),
                name.GetEntityEventRemoveMethodName()
            );
        });
        static public EvtInfoEX GetInstanceEventEvt(this Type item, string name)
        {
            return GET_INSTANCE_EVENT_EVT.Fetch(item, name);
        }
    }
}