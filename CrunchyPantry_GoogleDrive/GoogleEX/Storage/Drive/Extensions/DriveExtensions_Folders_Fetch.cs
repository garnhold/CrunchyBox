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
        static public class DriveExtensions_Folders_Fetch
        {
            static public string FetchFolderIdByName(this Drive item, string name, string parent_id)
            {
                string id;

                if(item.TryGetIdByName(name, parent_id, new IsFolderClause(), out id) == false)
                    item.CreateFolder(name, parent_id, out id);

                return id;
            }

            static public string FetchFolderIdByPath(this Drive item, IEnumerable<string> names, string parent_id)
            {
                foreach (string name in names)
                    parent_id = item.FetchFolderIdByName(name, parent_id);

                return parent_id;
            }

            static public string FetchFolderIdByPath(this Drive item, string path, string parent_id)
            {
                return item.FetchFolderIdByPath(path.SplitOn("/").EndBefore(""), parent_id);
            }
        }
    }
}