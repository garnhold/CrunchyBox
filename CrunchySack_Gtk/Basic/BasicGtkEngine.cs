using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Gtk;

namespace Crunchy.Sack_Gtk
{
    using Dough;
    using Noodle;
    using Sack;

    public class BasicGtkEngine : GtkEngine
    {
        static private readonly DistributedInitilizationInstance<BasicGtkEngine, BasicGtkEngineInitilizerAttribute> INSTANCE = new DistributedInitilizationInstance<BasicGtkEngine, BasicGtkEngineInitilizerAttribute>();
        static public BasicGtkEngine GetInstance()
        {
            return INSTANCE.Get();
        }

        private BasicGtkEngine()
        {
        }
    }
}