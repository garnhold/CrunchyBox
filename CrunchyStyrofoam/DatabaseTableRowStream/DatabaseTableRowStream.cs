using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

namespace Crunchy.Styrofoam
{
    using Dough;
    using Salt;
    
    public class DatabaseTableRowStream : WrappedStream
    {
        private bool can_read;
        private bool can_write;

        private DatabaseTableRow row;
        private DatabaseTableField field;

        private MemoryStream memory_stream;

        public override bool CanRead { get { return can_read; } }
        public override bool CanWrite { get { return can_write; } }

        protected override void FlushInternal()
        {
            if (can_write)
            {
                row.SetValue(field, memory_stream.GetBuffer());
                row.Store();
            }
        }

        public DatabaseTableRowStream(DatabaseTableRow r, DatabaseTableField f, bool read, bool write)
        {
            can_read = read;
            can_write = write;

            row = r;
            field = f;

            if (can_read)
                memory_stream = row.GetValue<byte[]>(field).GetMemoryStream();
            else
                memory_stream = new MemoryStream();

            Initialize(memory_stream);
        }
    }
}