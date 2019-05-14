using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;

using CrunchyDough;
using CrunchyNoodle;
using CrunchySack;

namespace CrunchySack_Android
{
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