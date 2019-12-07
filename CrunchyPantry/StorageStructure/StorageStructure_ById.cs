using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public partial class StorageStructure_ById : StorageStructure<FileSnapshot_ById>
    {
        private string root_folder_id;

        private bool is_dirty;
        private Dictionary<string, FileSnapshot_ById> files_by_id;
        private SortedList<string, FileSnapshot_ById> files_by_path;

        public void Validate()
        {
            if (is_dirty)
            {
                files_by_id.Values.Process(f => f.Reset());

                files_by_path.Set(
                    files_by_id.Values
                        .Skip(f => f.GetPath() == null)
                        .ConvertToValueOfPair(f => f.GetPath())
                );

                is_dirty = false;
            }
        }

        public StorageStructure_ById(string r)
        {
            root_folder_id = r;

            files_by_id = new Dictionary<string, FileSnapshot_ById>();
            files_by_path = new SortedList<string, FileSnapshot_ById>();
        }

        public override void Clear()
        {
            files_by_id.Clear();
            files_by_path.Clear();

            is_dirty = true;
        }

        public override void Add(FileSnapshot_ById file)
        {
            files_by_id.Add(file.GetId(), file);

            is_dirty = true;
        }

        public void Remove(string id)
        {
            files_by_id.Remove(id);

            is_dirty = true;
        }

        public bool TryGetFileById(string id, out FileSnapshot_ById file)
        {
            return files_by_id.TryGetValue(id, out file);
        }

        public override bool TryGetFile(string path, out FileSnapshot_ById file)
        {
            Validate();

            return files_by_path.TryGetValue(path, out file);
        }

        public override IEnumerable<string> GetPaths(string path)
        {
            Validate();

            return files_by_path.NarrowStartsWith(path)
                .Convert(p => p.Value.GetPath());
        }

        public string GetRootFolderId()
        {
            return root_folder_id;
        }
    }
}