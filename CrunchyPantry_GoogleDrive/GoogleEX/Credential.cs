using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Pantry_GoogleDrive
{
    using Dough;
    using Noodle;
    
    namespace GoogleEX
    {
        public class Credential
        {
            private List<string> scopes;

            private string client_secret_filename;
            private string credential_foldername;

            private UserCredential credential;

            public Credential(string sf, string cf, IEnumerable<string> s)
            {
                scopes = s.ToList();

                client_secret_filename = sf;
                credential_foldername = cf;
            }

            public UserCredential GetUserCredential()
            {
                if (credential == null)
                {
                    CrunchyDough.Files.GetStreamSystem().AttemptRead<UserCredential>(client_secret_filename, delegate(Stream stream) {
                        return GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            scopes,
                            "user",
                            CancellationToken.None,
                            new FileDataStore(credential_foldername, true)
                        ).Result;
                    }, out credential);
                }

                return credential;
            }
        }
    }
}