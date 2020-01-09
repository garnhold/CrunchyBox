using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Crunchy.Sack.WinForms
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class BasicWinFormsEngine : WinFormsEngine
    {
        static private readonly DistributedInitilizationInstance<BasicWinFormsEngine, BasicWinFormsEngineInitilizerAttribute> INSTANCE = new DistributedInitilizationInstance<BasicWinFormsEngine, BasicWinFormsEngineInitilizerAttribute>();
        static public BasicWinFormsEngine GetInstance()
        {
            return INSTANCE.Get();
        }

        private BasicWinFormsEngine()
        {
        }
    }
}