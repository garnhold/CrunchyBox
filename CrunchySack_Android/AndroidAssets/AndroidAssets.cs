using System;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;
using Android.Widget;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    static public class AndroidAssets
    {
        static public StreamSystem GetStreamSystem()
        {
            return Application.Context.Assets.GetStreamSystem();
        }
    }
}