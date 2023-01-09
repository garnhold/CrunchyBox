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
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;

namespace Crunchy.Google
{
    static public class SheetsServiceExtensions_Get
    {
        static public async Task<ValueRange> GetRawValueRange(this SheetsService item, string id, string range)
        {
            return await item.Spreadsheets.Values.Get(id, range).ExecuteAsync();
        }
        static public async Task<ValueRange> GetRawValueRange(this SheetsService item, string id, SheetRange range)
        {
            return await item.GetRawValueRange(id, range.ToA1());
        }

        static public async Task<IList<string>> GetRawValueRow(this SheetsService item, string id, string range)
        {
            return await item.GetRawValueRange(id, range)
                .Then(r => r.Values.GetFirst().Convert(v => v.ToStringEX()));
        }
        static public async Task<IList<string>> GetRawValueRow(this SheetsService item, string id, SheetRange range)
        {
            return await item.GetRawValueRow(id, range.ToA1());
        }

        static public async Task<string> GetRawValueCell(this SheetsService item, string id, string range)
        {
            return await item.GetRawValueRow(id, range)
                .Then(r => r.GetFirst());
        }
        static public async Task<string> GetRawValueCell(this SheetsService item, string id, SheetRange range)
        {
            return await item.GetRawValueCell(id, range.ToA1());
        }
    }
}