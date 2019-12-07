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
    namespace GoogleEX
    {
        static public class DriveExtensions_SubFolders
        {
            static public IEnumerable<string> GetSubFolderIds(this Drive drive, string parent_id)
            {
                Dictionary<string, List<string>> parent_id_to_ids = drive.GetFiles(new Clause_All(
                    new IsFolderClause(),
                    new IsNotTrashedClause()
                )).Convert(f => 
                    f.Parents.Convert(p => KeyValuePair.New(p, f.Id))
                ).ToMultiDictionary();

                return parent_id.TraverseWeb(i => parent_id_to_ids.GetValues(i));
            }
        }
    }
}