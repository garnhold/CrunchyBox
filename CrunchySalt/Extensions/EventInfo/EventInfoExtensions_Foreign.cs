using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class EventInfoExtensions_Foreign
    {
        static public EventInfo GetNativeEventInfo(this EventInfo item)
        {
            ForeignEventInfo foreign_event_info;

            if (item.Convert<ForeignEventInfo>(out foreign_event_info))
                return foreign_event_info.GetNativeEventInfo();

            return item;
        }
    }
}