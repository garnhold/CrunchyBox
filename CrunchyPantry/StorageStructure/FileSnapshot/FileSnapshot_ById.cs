using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public class FileSnapshot_ById : FileSnapshot
    {
        private string id;
        private string parent_id;

        private string path;
        private StorageStructure_ById structure;

        private string CalculatePath()
        {
            if (parent_id == structure.GetRootFolderId())
                return GetName();

            FileSnapshot_ById parent;
            if (structure.TryGetFileById(parent_id, out parent))
                return Filename.ForwardCombine(parent.GetPath(), GetName());

            return null;
        }

        public FileSnapshot_ById(string i, string pi, string n, string m, string h, DateTime w, StorageStructure_ById s) : base(n, m, h, w)
        {
            id = i;
            parent_id = pi;

            path = null;
            structure = s;
        }

        public void Reset()
        {
            path = null;
        }

        public string GetId()
        {
            return id;
        }

        public string GetParentId()
        {
            return parent_id;
        }

        public override string GetPath()
        {
            if (path == null)
                path = CalculatePath();

            return path;
        }
    }
}