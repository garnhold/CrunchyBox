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
        static public class DriveExtensions_Get
        {
            static public bool TryGetIdByName(this Drive item, string name, string parent_id, Clause clause, out string id)
            {
                Google.Apis.Drive.v3.Data.File file;

                if (item.GetFiles(new Clause_All(
                    new NameClause(ClauseType_String.EqualTo, name),
                    new ParentsClause(ClauseType_InCollection.In, parent_id),
                    new IsNotTrashedClause(),
                    clause
                )).TryGetOnly(out file))
                {
                    id = file.Id;
                    return true;
                }

                id = null;
                return false;
            }
            static public string GetIdByName(this Drive item, string name, string parent_id, Clause clause)
            {
                string id;

                item.TryGetIdByName(name, parent_id, clause, out id);
                return id;
            }

            static public bool TryGetIdByPath(this Drive item, IEnumerable<string> path, string parent_id, Clause clause, out string id)
            {
                id = null;

                foreach (string name in path)
                {
                    if (item.TryGetIdByName(name, parent_id, clause, out id) == false)
                        return false;

                    parent_id = id;
                }

                return true;
            }
            static public string GetIdByPath(this Drive item, IEnumerable<string> path, string parent_id, Clause clause)
            {
                string id;

                item.TryGetIdByPath(path, parent_id, clause, out id);
                return id;
            }

            static public bool TryGetIdByPath(this Drive item, string path, string parent_id, Clause clause, out string id)
            {
                return item.TryGetIdByPath(path.SplitOn("/"), parent_id, clause, out id);
            }
            static public string GetIdByPath(this Drive item, string path, string parent_id, Clause clause)
            {
                string id;

                item.TryGetIdByPath(path, parent_id, clause, out id);
                return id;
            }
        }
    }
}