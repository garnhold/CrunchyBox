using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Noodle;
using Crunchy.Dinner;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    static public class UserCredentialExtensions_QuerySheet
    {
        static public async Task<GoogleSelection<T>> QuerySheet<T>(this UserCredential item, string id, string query) where T : Enum
        {
            HttpWebRequest request = WebRequest.CreateHttp(
                "https://docs.google.com/spreadsheets/d/" + id.EncodeUrlEntities() + "/gviz/tq?tq=" + query.EncodeUrlEntities()
            );

            request.Method = "GET";
            request.Headers.Set("Authorization", "Bearer " + item.Token.AccessToken);

            using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return GoogleSelection<T>.FromGViz(
                        response.GetResponseStream()
                            .ReadText()
                    );
                }
            }

            return null;
        }
    }
}