using System;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Views;
using Android.Widget;

using CrunchyDough;
using CrunchySack;

namespace CrunchySack_Android
{
    static public class AndroidAssets
    {
        static public StreamSystem GetStreamSystem()
        {
            return Application.Context.Assets.GetStreamSystem();
        }
    }
}