using System;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Salt
{
    using Dough;
    
    static public class EmitDebugger
    {
        static private Enablable DEBUG_OPTION;
        static public Enablable Get()
        {
            if (DEBUG_OPTION == null)
                DEBUG_OPTION = new Enablable(false);

            return DEBUG_OPTION;
        }
    }
}