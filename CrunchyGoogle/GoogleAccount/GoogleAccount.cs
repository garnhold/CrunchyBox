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
        private GoogleApp app;
        private string profile;

        private UserCredential user_credential;
        private BaseClientService.Initializer initializer;

        private DriveService drive_service;
        private SheetsService sheets_service;

        public GoogleAccount(GoogleApp a, string p)
        {
            app = a;
            profile = p;
        }

        public GoogleAccount(GoogleApp a) : this(a, "default") { }

        public GoogleApp GetApp()
        {
            return app;
        }

        public async Task<UserCredential> GetUserCredential()
        {
            if (user_credential == null)
            {
                user_credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromFile("google_credentials.json").Secrets,
                    app.GetScopes(),
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