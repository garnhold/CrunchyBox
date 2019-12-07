using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Upload;
using Google.Apis.Download;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Crunchy.Pantry;
using CrunchyPantry_GoogleDrive.GoogleEX;
using CrunchyPantry_GoogleDrive.GoogleEX.Storage;

namespace Crunchy.Pantry_GoogleDrive
{
    static public class FileExtensions
    {
        static public FileSnapshot_ById MakeSnapshot(this Google.Apis.Drive.v3.Data.File item, StorageStructure_ById structure)
        {
            return new FileSnapshot_ById(
                item.Id,
                item.Parents.GetOnly(),
                item.Name,
                item.MimeType,
                item.Md5Checksum,
                item.ModifiedTime.Solidify(),
                structure
            );
        }
    }
}