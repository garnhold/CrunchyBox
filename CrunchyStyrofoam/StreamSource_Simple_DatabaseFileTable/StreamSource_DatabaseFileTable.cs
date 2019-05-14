using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    public class StreamSource_DatabaseFileTable : StreamSource
    {
        private DatabaseTable table;
        private DatabaseTableField data_field;

        public StreamSource_DatabaseFileTable(DatabaseTable t, DatabaseTableField f)
        {
            table = t;
            data_field = f;
        }

        public override AttemptResult DeleteStream(string path, long milliseconds = 25)
        {
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = 25)
        {
            stream = table.RetrieveByPrimaryValue(path).IfNotNull(r => r.GetReadStream(data_field));
            if (stream != null)
                return AttemptResult.Succeeded;

            return AttemptResult.Failed;
        }

        public override AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = 25)
        {
            stream = table.CreateRow(path).GetWriteStream(data_field);
            if (stream != null)
                return AttemptResult.Succeeded;

            return AttemptResult.Failed;
        }

        public override bool DoesStreamExist(string path)
        {
            return table.HasPrimaryValue(path);
        }

        public override IEnumerable<string> GetStreamPaths(string path)
        {
        }
    }
}