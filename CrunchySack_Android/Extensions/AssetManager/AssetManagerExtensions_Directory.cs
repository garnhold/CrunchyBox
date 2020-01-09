using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;

namespace Crunchy.Sack_Android
{
    using Dough;
    
    static public class AssetManagerExtensions_Directory
    {
        static public bool DoesDirectoryExist(this AssetManager item, string path)
        {
            if(item.List(path).IsNotEmpty())
                return true;

            return false;
        }
    }
}