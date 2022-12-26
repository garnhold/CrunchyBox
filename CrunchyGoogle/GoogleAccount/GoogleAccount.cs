using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Noodle;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    public class GoogleAccount
    {
        private string profile;
        private List<string> scopes;

        private UserCredential user_credential;
        private BaseClientService.Initializer initializer;

        private DriveService drive_service;
        private SheetsService sheets_service;

        public GoogleAccount(string p, IEnumerable<string> s)
        {
            profile = p;
            scopes = s.ToList();
        }
        public GoogleAccount(string p, params string[] s) : this(p, (IEnumerable<string>)s) { }

        public async Task<UserCredential> GetUserCredential()
        {
            if (user_credential == null)
            {
                user_credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromFile("google_credentials.json").Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(Filename.MakeDataFilename("Google", profile), true)
                );
            }

            return user_credential;
        }

        public async Task<BaseClientService.Initializer> GetInitializer()
        {
            if (initializer == null)
            {
                initializer = new BaseClientService.Initializer() {
                    HttpClientInitializer = await GetUserCredential(),
                    ApplicationName = ProgramInfo.GetId()
                };
            }

            return initializer;
        }

        public async Task<DriveService> GetDriveService()
        {
            if (drive_service == null)
                drive_service = new DriveService(await GetInitializer());

            return drive_service;
        }

        public async Task<SheetsService> GetSheetsService()
        {
            if (sheets_service == null)
                sheets_service = new SheetsService(await GetInitializer());

            return sheets_service;
        }
    }
}