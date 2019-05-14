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
        static public class DriveExtensions_Clauses
        {
            static public Clause CreateRecursiveFolderClause(this Drive drive, string parent_id)
            {
                return new Clause_Any(
                    drive.GetSubFolderIds(parent_id).Prepend(parent_id)
                        .Convert(i => new ParentsClause(ClauseType_InCollection.In, i))
                );
            }
        }
    }
}