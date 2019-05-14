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
    public class StreamSource_FileDatabase : StreamSource
    {
        private StreamSource_DatabaseFileTable stream_source;

        public StreamSource_FileDatabase(Database database)
        {
            DatabaseTable table = database.AddTable(new DatabaseTable("files"));

            DatabaseTableField filename_field = table.AddField(new DatabaseTableField("filename", DatabaseTableFieldType.TEXT, true, false, false, true));
            DatabaseTableField data_field = table.AddField(new DatabaseTableField("data", DatabaseTableFieldType.BLOB));

            stream_source = new StreamSource_DatabaseFileTable(table, data_field);
        }

        public override AttemptResult DeleteStream(string path, long milliseconds = 25)
        {
            return stream_source.DeleteStream(path, milliseconds);
        }

        public override AttemptResult OpenStreamForReading(string path, out Stream stream, long milliseconds = 25)
        {
            return stream_source.OpenStreamForReading(path, out stream, milliseconds);
        }

        public override AttemptResult OpenStreamForWriting(string path, out Stream stream, long milliseconds = 25)
        {
            return stream_source.OpenStreamForWriting(path, out stream, milliseconds);
        }

        public override string GetStreamHash(string path, long milliseconds = 25)
        {
            return stream_source.GetStreamHash(path, milliseconds);
        }

        public override bool DoesStreamExist(string id)
        {
            return stream_source.DoesStreamExist(id);
        }

        public override IEnumerable<string> GetStreamPaths(string path)
        {
            return stream_source.GetStreamPaths(path);
        }
    }
}