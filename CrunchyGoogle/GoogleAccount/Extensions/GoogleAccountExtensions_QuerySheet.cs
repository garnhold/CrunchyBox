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

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace Crunchy.Google
{
    static public class GoogleAccountExtensions_QuerySheet
    {
        static public async Task<GoogleSelection<T>> QuerySheet<T>(this GoogleAccount item, string id, string query) where T : Enum
        {
            return await item.GetUserCredential()
                .Then(c => c.QuerySheet<T>(id, query));
        }
    }
}