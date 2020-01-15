using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Avalonia;

namespace Crunchy.Sack_Avalonia
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class BasicAvaloniaEngine : AvaloniaEngine
    {
        static private readonly DistributedInitilizationInstance<BasicAvaloniaEngine, BasicAvaloniaEngineInitilizerAttribute> INSTANCE = new DistributedInitilizationInstance<BasicAvaloniaEngine, BasicAvaloniaEngineInitilizerAttribute>();
        static public BasicAvaloniaEngine GetInstance()
        {
            return INSTANCE.Get();
        }

        private BasicAvaloniaEngine()
        {
        }
    }
}