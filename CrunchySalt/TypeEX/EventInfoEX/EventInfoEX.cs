using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public class EventInfoEX : EventInfoPass
    {
        private EventInfo native_event_info;

        private BasicEventRegister basic_event_register;
        private BasicEventDeregister basic_event_deregister;

        static private OperationCache<EventInfoEX, EventInfo> GET_EVENT_INFO_EX = ReflectionCache.Get().NewOperationCache("GET_EVENT_INFO_EX", delegate(EventInfo event_info) {
            return new EventInfoEX(event_info);
        });
        static public EventInfoEX GetEventInfoEX(EventInfo event_info)
        {
            EventInfoEX cast;

            if (event_info != null)
            {
                if (event_info.Convert<EventInfoEX>(out cast))
                    return cast;

                return GET_EVENT_INFO_EX.Fetch(event_info);
            }

            return null;
        }

        protected EventInfoEX(EventInfo p)
        {
            native_event_info = p;
        }

        public override EventInfo GetNativeEventInfo()
        {
            return native_event_info;
        }

        public BasicEventRegister GetBasicEventRegister()
        {
            if (basic_event_register == null)
                basic_event_register = GetNativeEventInfo().CreateDynamicEventRegisterDelegate<BasicEventRegister>();

            return basic_event_register;
        }

        public BasicEventDeregister GetBasicEventDeregister()
        {
            if (basic_event_deregister == null)
                basic_event_deregister = GetNativeEventInfo().CreateDynamicEventDeregisterDelegate<BasicEventDeregister>();

            return basic_event_deregister;
        }
    }
}