using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class StorageStructure_ByPath : StorageStructure<FileSnapshot_ByPath>
    {
        private SortedList<string, FileSnapshot_ByPath> files_by_path;

        public StorageStructure_ByPath()
        {
            files_by_path = new SortedList<string, FileSnapshot_ByPath>();
        }

        public override void Clear()
        {
            files_by_path.Clear();
        }

        public override void Add(FileSnapshot_ByPath file)
        {
            files_by_path.Add(file.GetPath(), file);
        }

        public void Remove(string path)
        {
            files_by_path.Remove(path);
        }

        public override bool TryGetFile(string path, out FileSnapshot_ByPath file)
        {
            return files_by_path.TryGetValue(path, out file);
        }

        public override IEnumerable<string> GetPaths(string path)
        {
            return files_by_path.NarrowStartsWith(path)
                .Convert(p => p.Value.GetPath());
        }
    }
}