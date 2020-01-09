using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Noodle;
using Crunchy.Pantry;

using CrunchyPantry_GoogleDrive.GoogleEX;
using CrunchyPantry_GoogleDrive.GoogleEX.Storage;

namespace Crunchy.Pantry_GoogleDrive
{
    public class NookSystem_GoogleDrive : NookSystem_StorageStructure_Id
    {
        private Drive drive;

        private string change_token;

        protected override bool DeleteInternal(FileSnapshot_ById snapshot)
        {
            return drive.DeleteFile(snapshot.GetId()).IsDesired();
        }

        protected override bool ReadInternal(FileSnapshot_ById snapshot, Process<Stream> process)
        {
            return Transfer.StreamViaMemory(delegate(Stream stream) {
                return drive.ReadFileIntoStream(snapshot.GetId(), stream).IsDesired();
            }, process);
        }

        protected override bool CreateInternalViaParentId(string parent_id, string name, string mime_type, Process<Stream> process, out FileSnapshot_ById snapshot)
        {
            string id = null;
            string hash = null;
            DateTime last_write_time = default(DateTime);

            bool result = Transfer.StreamViaMemory(process, delegate(Stream stream) {
                return drive.CreateStreamToFile(name, parent_id, mime_type, stream, out id, out hash, out last_write_time).IsDesired();
            });

            snapshot = new FileSnapshot_ById(id, parent_id, name, mime_type, hash, last_write_time, GetStructure());
            return result;
        }

        protected override bool UpdateInternal(FileSnapshot_ById snapshot, Process<Stream> process)
        {
            return Transfer.StreamViaMemory(process, delegate(Stream stream) {
                return drive.UpdateStreamToFile(snapshot.GetId(), snapshot.GetMIMEType(), stream).IsDesired();
            });
        }

        protected override bool TryGetLocalPathInternal(FileSnapshot_ById snapshot, out string local_path)
        {
            local_path = null;
            return false;
        }

        protected override void InitilizeStructure()
        {
            change_token = drive.StartRecordChanges();

            GetStructure().Set(
                drive.GetFilesInFolderRecursive(new IsNotTrashedClause(), GetStructure().GetRootFolderId())
                    .Convert(f => f.MakeSnapshot(GetStructure()))
            );
        }

        protected override void UpdateStructure()
        {
            foreach (Google.Apis.Drive.v3.Data.Change change in drive.UpdateRecordChanges(change_token, out change_token))
            {
                if (change.Removed.Solidify())
                    GetStructure().Remove(change.FileId);
                else
                    GetStructure().Add(change.File.MakeSnapshot(GetStructure()));
            }
        }

        public NookSystem_GoogleDrive(Drive d, string r) : base(Duration.Minutes(5.0f), Duration.Seconds(6.0f), r)
        {
            drive = d;
        }
    }
}