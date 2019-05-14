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

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

using CrunchyPantry;
using CrunchyPantry_GoogleDrive.GoogleEX;
using CrunchyPantry_GoogleDrive.GoogleEX.Storage;

namespace CrunchyPantry_GoogleDrive
{
    namespace GoogleEX
    {
        static public class DriveExtensions_Files
        {
            static public IEnumerable<Google.Apis.Drive.v3.Data.File> GetFilesInFolderRecursive(this Drive item, Clause clause, string parent_id)
            {
                return item.GetFiles(new Clause_All(
                    clause,
                    item.CreateRecursiveFolderClause(parent_id)
                ));
            }
        }
    }
}