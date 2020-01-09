using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows;

namespace Crunchy.Sack.WPF
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class BasicWPFEngine : WPFEngine
    {
        static private readonly DistributedInitilizationInstance<BasicWPFEngine, BasicWPFEngineInitilizerAttribute> INSTANCE = new DistributedInitilizationInstance<BasicWPFEngine, BasicWPFEngineInitilizerAttribute>();
        static public BasicWPFEngine GetInstance()
        {
            return INSTANCE.Get();
        }

        private BasicWPFEngine()
        {
        }
    }
}