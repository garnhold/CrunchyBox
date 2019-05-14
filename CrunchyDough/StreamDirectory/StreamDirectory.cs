using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class StreamDirectory : StreamItem, StreamSystemDirectory
    {
        public StreamDirectory(string n, StreamDirectory d) : base(n, d)
        {
        }

        public string GetChildPath(string name)
        {
            return this.TraverseWithSelf(d => d.GetParentDirectory())
                .Convert(d => d.GetName())
                .Reverse()
                .Append(Filename.CleanFilename(name))
                .Join("/");
        }

        public IEnumerable<StreamFile> GetSubFiles()
        {
            return GetStreamSystem().GetStreamNames(GetPath())
                .Convert(n => new StreamFile(n, this));
        }

        public IEnumerable<StreamDirectory> GetSubDirectorys()
        {
            return GetStreamSystem().GetDirectoryNames(GetPath())
                .Convert(n => new StreamDirectory(n, this));
        }

        public override string GetPath()
        {
            return GetParentDirectory().GetChildPath(GetName()) + "/";
        }
    }
}