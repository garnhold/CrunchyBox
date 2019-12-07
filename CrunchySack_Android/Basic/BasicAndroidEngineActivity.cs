using System;
using System.IO;

using Android;
using Android.OS;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    public abstract class BasicAndroidEngineActivity : AndroidEngineActivity
    {
        public BasicAndroidEngineActivity() : base(BasicAndroidEngine.GetInstance()) { }
    }
}