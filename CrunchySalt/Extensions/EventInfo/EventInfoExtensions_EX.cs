using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class EventInfoExtensions_EX
    {
        static public EventInfoEX GetEventInfoEX(this EventInfo item)
        {
            return EventInfoEX.GetEventInfoEX(item);
        }
    }
}