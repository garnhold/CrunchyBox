using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAndroidEngineInitilizerAttribute : Attribute
    {
    }
}