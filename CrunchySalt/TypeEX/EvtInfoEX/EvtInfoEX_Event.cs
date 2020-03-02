using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;

    public class EvtInfoEX_Event : EvtInfoEX
    {
        private EventInfoEX event_info;

        private EvtInfoEX_MethodPair method_pair;

        public EvtInfoEX_Event(EventInfoEX e)
        {
            event_info = e;

            method_pair = new EvtInfoEX_MethodPair(
                e.GetAddMethod(true).GetMethodInfoEX(),
                e.GetRemoveMethod(true).GetMethodInfoEX()
            );
        }

        public override string GetName()
        {
            return event_info.Name;
        }

        public override Type GetEvtType()
        {
            return event_info.EventHandlerType;
        }

        public override Type GetDeclaringType()
        {
            return event_info.DeclaringType;
        }

        public override BasicEventRegister GetBasicEventRegister()
        {
            return method_pair.GetBasicEventRegister();
        }

        public override BasicEventDeregister GetBasicEventDeregister()
        {
            return method_pair.GetBasicEventDeregister();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return event_info.GetAllCustomAttributes(inherit);
        }

        public override void EmitRegisterEvent(ILCanvas canvas, ILValue target, ILValue evt)
        {
            method_pair.EmitRegisterEvent(canvas, target, evt);
        }

        public override void EmitDeregisterEvent(ILCanvas canvas, ILValue target, ILValue evt)
        {
            method_pair.EmitDeregisterEvent(canvas, target, evt);
        }

        public EventInfoEX GetEventInfo()
        {
            return event_info;
        }

        public override int GetHashCode()
        {
            return event_info.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            EvtInfoEX_Event cast;

            if (obj.Convert<EvtInfoEX_Event>(out cast))
            {
                if (cast.event_info == event_info)
                    return true;
            }

            return false;
        }
    }
}