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
    static public class SheetsServiceExtensions_Append
    {
        static public async Task<AppendValuesResponse> AppendValueRange(this SheetsService item, string id, ValueRange value_range, string range = "A1")
        {
            return await item.Spreadsheets.Values.Append(value_range, id, range).ExecuteAsync();
        }

        static public async Task<AppendValuesResponse> AppendValueRow(this SheetsService item, string id, IList<object> values, string range = "A1")
        {
            return await item.AppendValueRange(
                id,
                new ValueRange() {
                    Values = values.WrapAsIList(),
                    MajorDimension = "ROWS"
                },
                range
            );
        }

        static public async Task<AppendValuesResponse> AppendValueCell(this SheetsService item, string id, object value, string range = "A1")
        {
            return await item.AppendValueRow(id, value.WrapAsIList(), range);
        }
    }
}