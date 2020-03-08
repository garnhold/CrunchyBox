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

        private EvtInfoEX_Methods methods;

        public EvtInfoEX_Event(EventInfoEX e)
        {
            event_info = e;

            methods = new EvtInfoEX_Methods(
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

        public override bool CanAdd()
        {
            return methods.CanAdd();
        }

        public override bool CanRemove()
        {
            return methods.CanRemove();
        }

        public override bool IsAddPublic()
        {
            return methods.IsAddPublic();
        }

        public override bool IsRemovePublic()
        {
            return methods.IsRemovePublic();
        }

        public override BasicDelegateAdder GetBasicDelegateAdder()
        {
            return methods.GetBasicDelegateAdder();
        }

        public override BasicDelegateRemover GetBasicDelegateRemover()
        {
            return methods.GetBasicDelegateRemover();
        }

        public override IEnumerable<Attribute> GetAllCustomAttributes(bool inherit)
        {
            return event_info.GetAllCustomAttributes(inherit);
        }

        public override void EmitAddDelegate(ILCanvas canvas, ILValue target, ILValue @delegate)
        {
            methods.EmitAddDelegate(canvas, target, @delegate);
        }

        public override void EmitRemoveDelegate(ILCanvas canvas, ILValue target, ILValue @delegate)
        {
            methods.EmitRemoveDelegate(canvas, target, @delegate);
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