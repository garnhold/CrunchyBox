using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;
using System.Reflection.Emit;

using System.Globalization;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class EventInfoExtensions_Evt
    {
        static public EvtInfoEX GetEvt(this EventInfo item)
        {
            return new EvtInfoEX_Event(item.GetEventInfoEX());
        }
    }
}