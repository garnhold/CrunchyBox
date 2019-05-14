using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyPantry
{
    public class NookSystem_Local : NookSystem
    {
        public override bool Delete(string path)
        {
            return Files.DeleteFile(path).IsDesired();
        }

        public override bool IsPresent(string path)
        {
            return Files.DoesFileExist(path);
        }

        public override string GetHash(string path)
        {
            return Files.GetStreamSystem().GetStreamHash(path).ToHexString();
        }

        public override bool Read(string path, Process<Stream> process)
        {
            return Files.GetStreamSystem().AttemptRead(path, process).IsDesired();
        }

        public override bool Write(string path, Process<Stream> process)
        {
            return Files.GetStreamSystem().Write(path, process).IsDesired();
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            local_path = Filename.GetAbsolutePath(path);
            return true;
        }

        public override IEnumerable<string> GetPaths(string path)
        {
            return Directory.GetFiles(path, "*", SearchOption.AllDirectories)
                .Narrow(p => Files.DoesFileExist(p));
        }
    }
}