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
using Google.Apis.Sheets.v4.Data;
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

            public async Task<Row> CreateEmptyRow()
            {
                return await GetHeaderInfo()
                    .Then(i => i.CreateEmptyRow());
            }

            public async Task<int> Insert(Row row)
            {
                AppendValuesResponse response = await account.GetSheetsService()
                    .Then(s => s.AppendRawValueRow(id, row.GetValues()));

                if (response != null)
                {
                    SheetRange sheet_range;
                    if (SheetRange.TryParseA1(response.Updates.UpdatedRange, out sheet_range))
                        return sheet_range.first.row_index.Solidify();
                }

                return -1;
            }

            public async Task<GoogleSelection<ID_ENUM>> Select(Query query)
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