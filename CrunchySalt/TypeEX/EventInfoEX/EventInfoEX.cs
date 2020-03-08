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

        private BasicDelegateAdder basic_delegate_adder;
        private BasicDelegateRemover basic_delegate_remover;

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

        public BasicDelegateAdder GetBasicDelegateAdder()
        {
            if (basic_delegate_adder == null)
                basic_delegate_adder = GetNativeEventInfo().CreateDynamicDelegateAdderDelegate<BasicDelegateAdder>();

            return basic_delegate_adder;
        }

        public BasicDelegateRemover GetBasicDelegateRemover()
        {
            if (basic_delegate_remover == null)
                basic_delegate_remover = GetNativeEventInfo().CreateDynamicDelegateRemoverDelegate<BasicDelegateRemover>();

            return basic_delegate_remover;
        }
    }
}