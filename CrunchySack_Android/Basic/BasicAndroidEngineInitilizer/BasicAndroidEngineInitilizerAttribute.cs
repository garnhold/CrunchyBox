using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAndroidEngineInitilizerAttribute : Attribute
    {
    }
}