using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;

namespace CrunchySack_Android
{
    static public class AssetManagerExtensions_StreamSystem
    {
        static public StreamSystem GetStreamSystem(this AssetManager item)
        {
            return new StreamSystem_AssetManager(item);
        }
    }
}