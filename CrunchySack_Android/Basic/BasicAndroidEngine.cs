using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Noodle;
    using Sack;
    
    public class BasicAndroidEngine : AndroidEngine
    {
        static private readonly DistributedInitilizationInstance<BasicAndroidEngine, BasicAndroidEngineInitilizerAttribute> INSTANCE = new DistributedInitilizationInstance<BasicAndroidEngine, BasicAndroidEngineInitilizerAttribute>();
        static public BasicAndroidEngine GetInstance()
        {
            return INSTANCE.Get();
        }

        private BasicAndroidEngine()
        {
        }
    }
}