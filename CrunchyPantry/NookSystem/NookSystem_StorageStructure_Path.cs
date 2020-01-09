using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Pantry
{
    using Dough;
    
    public abstract class NookSystem_StorageStructure_Path : NookSystem_StorageStructure<StorageStructure_ByPath, FileSnapshot_ByPath>
    {
        public NookSystem_StorageStructure_Path(Duration id, Duration ud) : base(new StorageStructure_ByPath(), id, ud)
        {
        }
    }
}