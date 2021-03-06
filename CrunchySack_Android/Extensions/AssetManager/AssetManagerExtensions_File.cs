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
    
    static public class AssetManagerExtensions_File
    {
        static public bool DoesFileExist(this AssetManager item, string path)
        {
            string directory = Filename.GetDirectory(path);
            string filename = Filename.GetFilenameWithExtension(path);

            if (item.List(directory).Has(filename))
                return true;

            return false;
        }
    }
}