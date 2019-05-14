using System;
using System.IO;

using Android;
using Android.OS;
using Android.App;
using Android.Views;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    public abstract class BasicAndroidEngineActivity : AndroidEngineActivity
    {
        public BasicAndroidEngineActivity() : base(BasicAndroidEngine.GetInstance()) { }
    }
}