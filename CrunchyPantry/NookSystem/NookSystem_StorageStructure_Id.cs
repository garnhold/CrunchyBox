using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    using Noodle;
    
    public abstract class NookSystem_StorageStructure_Id : NookSystem_StorageStructure<StorageStructure_ById, FileSnapshot_ById>
    {
        protected abstract bool CreateInternalViaParentId(string parent_id, string name, MIMEType mime_type, Process<Stream> process, out FileSnapshot_ById snapshot);

        protected override bool CreateInternal(string path, string name, MIMEType mime_type, Process<Stream> process, out FileSnapshot_ById snapshot)
        {
            FileSnapshot_ById parent_file;

            if (GetStructure().TryGetFile(Filename.GetDirectory(path), out parent_file))
                return CreateInternalViaParentId(parent_file.GetId(), name, mime_type, process, out snapshot);

            snapshot = null;
            return false;
        }

        public NookSystem_StorageStructure_Id(Duration id, Duration ud, string r) : base(new StorageStructure_ById(r), id, ud)
        {
        }
    }
}