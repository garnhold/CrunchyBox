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
        public class Drive
        {
            private DriveService drive_service;

            public const string ROOT_FOLDER_ID = "root";
            public const string FOLDER_MIME_TYPE = "application/vnd.google-apps.folder";

            public Drive(string n, Credential c)
            {
                drive_service = new DriveService(new BaseClientService.Initializer() {
                    ApplicationName = n,
                    HttpClientInitializer = c.GetUserCredential()
                });
            }

            public AttemptResult DeleteFile(string id)
            {
                try
                {
                    drive_service.Files.Delete(id).Execute();
                }
                catch (Google.GoogleApiException exception)
                {
                    return exception.Error.GetAttemptResult();
                }

                return AttemptResult.Succeeded;
            }

            public AttemptResult RenameFile(string id, string new_filename)
            {
                FilesResource.UpdateRequest request = drive_service.Files.Update(
                    new Google.Apis.Drive.v3.Data.File() { Name = new_filename },
                    id
                );

                try
                {
                    request.Execute();
                }
                catch (Google.GoogleApiException exception)
                {
                    return exception.Error.GetAttemptResult();
                }

                return AttemptResult.Succeeded;
            }

            public AttemptResult ReadFileIntoStream(string id, Stream stream)
            {
                FilesResource.GetRequest request = drive_service.Files.Get(id);

                try
                {    
                    request.DownloadWithStatus(stream);
                }
                catch (Google.GoogleApiException exception)
                {
                    return exception.Error.GetAttemptResult();
                }

                return AttemptResult.Succeeded;
            }

            public AttemptResult CreateStreamToFile(string name, string parent_id, string mime_type, Stream stream, out string id, out string hash, out DateTime last_write_time)
            {
                FilesResource.CreateMediaUpload request = drive_service.Files.Create(
                    new Google.Apis.Drive.v3.Data.File() { 
                        Name = name,
                        Parents = new string[] { parent_id } 
                    },
                    stream,
                    mime_type
                );

                request.Fields = "id, name, md5Checksum, modifiedTime, parents";

                try
                {
                    request.Upload();
                    
                    id = request.ResponseBody.Id;
                    hash = request.ResponseBody.Md5Checksum;
                    last_write_time = request.ResponseBody.ModifiedTime.Solidify();
                }
                catch (Google.GoogleApiException exception)
                {
                    id = null;
                    hash = null;
                    last_write_time = default(DateTime);
                    return exception.Error.GetAttemptResult();
                }

                return AttemptResult.Succeeded;
            }

            public AttemptResult UpdateStreamToFile(string id, string mime_type, Stream stream)
            {
                FilesResource.UpdateMediaUpload request = drive_service.Files.Update(
                    new Google.Apis.Drive.v3.Data.File() { },
                    id,
                    stream,
                    mime_type
                );

                try
                {
                    request.Upload();
                }
                catch (Google.GoogleApiException exception)
                {
                    return exception.Error.GetAttemptResult();
                }

                return AttemptResult.Succeeded;
            }

            public AttemptResult CreateFolder(string folder_name, string parent_id, out string id)
            {
                FilesResource.CreateRequest request = drive_service.Files.Create(
                    new Google.Apis.Drive.v3.Data.File() {
                        Name = folder_name,
                        MimeType = FOLDER_MIME_TYPE,
                        Parents = new string[] { parent_id }
                    }
                );

                request.Fields = "id";

                try
                {
                    id = request.Execute().Id;
                }
                catch (Google.GoogleApiException)
                {
                    id = null;
                    return AttemptResult.Failed;
                }

                return AttemptResult.Succeeded;
            }

            public string StartRecordChanges()
            {
                ChangesResource.GetStartPageTokenRequest request = drive_service.Changes.GetStartPageToken();

                try
                {
                    return request.Execute().StartPageTokenValue;
                }
                catch (Google.GoogleApiException)
                {
                }

                return null;
            }

            public IEnumerable<Change> UpdateRecordChanges(string change_token, out string new_change_token)
            {
                string page_token = change_token;
                List<Change> changes = new List<Change>();

                new_change_token = change_token;

                do
                {
                    ChangeList result;
                    ChangesResource.ListRequest request = drive_service.Changes.List(page_token);

                    request.Spaces = "drive";
                    request.Fields = "nextPageToken, changes(removed, fileId, file(id, name, md5Checksum, modifiedTime, parents))";

                    try
                    {
                        result = request.Execute();
                    }
                    catch (Google.GoogleApiException)
                    {
                        break;
                    }

                    changes.AddRange(result.Changes);

                    if (result.NewStartPageToken != null)
                        new_change_token = result.NewStartPageToken;

                    page_token = result.NextPageToken;
                }
                while (page_token != null);

                return changes;
            }

            public IEnumerable<Google.Apis.Drive.v3.Data.File> GetFiles(Clause clause)
            {
                string page_token = null;
                string query_string = clause.CreateQueryString();

                do
                {
                    FileList result;
                    FilesResource.ListRequest request = drive_service.Files.List();

                    request.Q = query_string;
                    request.Spaces = "drive";
                    request.Fields = "nextPageToken, files(id, name, md5Checksum, modifiedTime, parents)";
                    request.PageToken = page_token;

                    try
                    {
                        result = request.Execute();
                    }
                    catch (Google.GoogleApiException)
                    {
                        break;
                    }

                    foreach (Google.Apis.Drive.v3.Data.File file in result.Files)
                        yield return file;

                    page_token = result.NextPageToken;
                }
                while (page_token != null);
            }
        }
    }
}