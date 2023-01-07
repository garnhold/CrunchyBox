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
using Crunchy.Dinner;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    public partial class GoogleSelection<ID_ENUM>
    {
        public class Sheet
        {
            private string id;
            private GoogleAccount account;

            private HeaderInfo header_info;

            public Sheet(string i, GoogleAccount a)
            {
                id = i;
                account = a;
            }

            public async Task<GoogleSelection<ID_ENUM>> DoQuery(Query query)
            {
                return await account.QuerySheet<ID_ENUM>(id, query.Render(await GetHeaderInfo()));
            }

            public async Task<HeaderInfo> GetHeaderInfo()
            {
                if (header_info == null)
                {
                    header_info = await account.QuerySheet<ID_ENUM>(id, "SELECT * WHERE 1 = 0")
                        .ThenIfNotNull(s => s.GetHeaderInfo());
                }

                return header_info;
            }
        }
    }
}