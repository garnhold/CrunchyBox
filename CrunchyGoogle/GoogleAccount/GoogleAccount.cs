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
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    public class GoogleAccount
    {
        private List<string> scopes;

        private UserCredential user_credential;
        private BaseClientService.Initializer initializer;

        private DriveService drive_service;

        public GoogleAccount(IEnumerable<string> s)
        {
            scopes = s.ToList();
        }

        public async Task<UserCredential> GetUserCredential()
        {
            if (user_credential == null)
            {
                user_credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromFile("google_credentials.json").Secrets,
                    scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore("token.json", true)
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
    }
}