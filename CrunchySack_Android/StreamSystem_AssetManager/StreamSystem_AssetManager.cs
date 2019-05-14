using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Android;
using Android.App;
using Android.Content;
using Android.Content.Res;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;
using CrunchySack;

namespace CrunchySack_Android
{
    public class StreamSystem_AssetManager : StreamSystem_ReadOnly
    {
        private AssetManager asset_manager;

        public StreamSystem_AssetManager(AssetManager a)
        {
            asset_manager = a;
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = 25)
        {
            stream = null;

            try
            {
                stream = asset_manager.Open(path);
                if (stream != null)
                    return AttemptResult.Succeeded;
            }
            catch (Java.IO.FileNotFoundException) { return AttemptResult.Failed; }
            catch (Java.IO.IOException) { return AttemptResult.Tried; }

            return AttemptResult.Failed;
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            local_path = "";

            return false;
        }

        public override bool DoesStreamExist(string path)
        {
            return asset_manager.DoesFileExist(path);
        }

        public override bool DoesDirectoryExist(string path)
        {
            return asset_manager.DoesDirectoryExist(path);
        }

        public override IEnumerable<string> GetStreamNames(string path)
        {
            return asset_manager.List(path).Narrow(n => DoesStreamExist(n));
        }

        public override IEnumerable<string> GetDirectoryNames(string path)
        {
            return asset_manager.List(path).Narrow(n => DoesDirectoryExist(n));
        }
    }
}