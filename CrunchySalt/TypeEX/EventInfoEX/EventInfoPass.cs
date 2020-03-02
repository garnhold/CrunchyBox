using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    public abstract class EventInfoPass : EventInfo, ForeignEventInfo
    {
        public abstract EventInfo GetNativeEventInfo();

        public override string ToString()
        {
            return EventHandlerType.ToString() + " " + Name;
        }

        public override Type DeclaringType { get { return GetNativeEventInfo().DeclaringType; } }
        public override MemberTypes MemberType { get { return GetNativeEventInfo().MemberType; } }
        public override int MetadataToken { get { return GetNativeEventInfo().MetadataToken; } }
        public override Module Module { get { return GetNativeEventInfo().Module; } }
        public override string Name { get { return GetNativeEventInfo().Name; } }
        public override Type ReflectedType { get { return GetNativeEventInfo().ReflectedType; } }
        public override object[] GetCustomAttributes(bool inherit) { return GetNativeEventInfo().GetCustomAttributes(inherit); }
        public override object[] GetCustomAttributes(Type attributeType, bool inherit) { return GetNativeEventInfo().GetCustomAttributes(attributeType, inherit); }
        public override bool IsDefined(Type attributeType, bool inherit) { return GetNativeEventInfo().IsDefined(attributeType, inherit); }

        public override EventAttributes Attributes { get { return GetNativeEventInfo().Attributes; } }

        public override MethodInfo GetAddMethod(bool nonPublic) { return GetNativeEventInfo().GetAddMethod(nonPublic); }
        public override MethodInfo[] GetOtherMethods(bool nonPublic) { return GetNativeEventInfo().GetOtherMethods(nonPublic); }
        public override MethodInfo GetRaiseMethod(bool nonPublic) { return GetNativeEventInfo().GetRaiseMethod(nonPublic); }
        public override MethodInfo GetRemoveMethod(bool nonPublic) { return GetNativeEventInfo().GetRemoveMethod(nonPublic); }
    }
}