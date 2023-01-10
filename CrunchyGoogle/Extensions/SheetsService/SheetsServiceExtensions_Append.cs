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
        static public async Task<AppendValuesResponse> AppendValueRange(this SheetsService item, string id, ValueRange value_range, string range = "A1", bool interpret=false)
        {
            SpreadsheetsResource.ValuesResource.AppendRequest request = item
                .Spreadsheets.Values.Append(value_range, id, range);

            request.InsertDataOption = SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum.INSERTROWS;
            request.ValueInputOption = interpret.ConvertBool(
                SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED,
                SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.RAW
            );
            return await request.ExecuteAsync();
        }
        static public async Task<AppendValuesResponse> AppendValueRange(this SheetsService item, string id, ValueRange value_range, SheetRange range, bool interpret=false)
        {
            return await item.AppendValueRange(id, value_range, range.ToA1(), interpret);
        }

        static public async Task<AppendValuesResponse> AppendValueRow(this SheetsService item, string id, IList<string> values, string range = "A1", bool interpret=false)
        {
            return await item.AppendValueRange(
                id,
                new ValueRange() {
                    Values = ((IList<object>)values).WrapAsIList(),
                    MajorDimension = "ROWS"
                },
                range,
                interpret
            );
        }
        static public async Task<AppendValuesResponse> AppendValueRow(this SheetsService item, string id, IList<string> values, SheetRange range, bool interpret=false)
        {
            return await item.AppendValueRow(id, values, range.ToA1(), interpret);
        }

        static public async Task<AppendValuesResponse> AppendValueCell(this SheetsService item, string id, string value, string range = "A1", bool interpret=false)
        {
            return await item.AppendValueRow(id, value.WrapAsIList(), range, interpret);
        }
        static public async Task<AppendValuesResponse> AppendValueCell(this SheetsService item, string id, string value, SheetRange range, bool raw=true)
        {
            return await item.AppendValueCell(id, value, range.ToA1(), raw);
        }
    }
}