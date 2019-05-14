using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Data.SQLite;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyStyrofoam
{
    static public class ApplicationFileDatabase
    {
        static private StreamSource_FileDatabase STREAM_SOURCE;
        static public StreamSource GetStreamSource()
        {
            if (STREAM_SOURCE == null)
            {
                STREAM_SOURCE = new StreamSource_FileDatabase(
                    Database.ConnectLazilyToFile<PeriodicProcess_Timer>(
                        Filename.MakeDataFilename("Database", "files.db")
                    )
                );
            }

            return STREAM_SOURCE;
        }
    }
}