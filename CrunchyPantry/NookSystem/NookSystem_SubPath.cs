using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyPantry
{
    public class NookSystem_SubPath : NookSystem
    {
        private string sub_path;
        private NookSystem nook_system;

        public NookSystem_SubPath(string s, NookSystem n)
        {
            sub_path = s;
            nook_system = n;
        }

        public override bool Delete(string path)
        {
            return nook_system.Delete(Filename.ForwardCombine(sub_path, path));
        }

        public override bool IsPresent(string path)
        {
            return nook_system.IsPresent(Filename.ForwardCombine(sub_path, path));
        }

        public override string GetHash(string path)
        {
            return nook_system.GetHash(Filename.ForwardCombine(sub_path, path));
        }

        public override bool Read(string path, Process<Stream> process)
        {
            return nook_system.Read(Filename.ForwardCombine(sub_path, path), process);
        }

        public override bool Write(string path, Process<Stream> process)
        {
            return nook_system.Write(Filename.ForwardCombine(sub_path, path), process);
        }

        public override bool TryGetLocalPath(string path, out string local_path)
        {
            return nook_system.TryGetLocalPath(Filename.ForwardCombine(sub_path, path), out local_path);
        }

        public override IEnumerable<string> GetPaths(string path)
        {
            return nook_system.GetPaths(Filename.ForwardCombine(sub_path, path));
        }
    }
}