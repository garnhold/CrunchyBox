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
    static public class SheetsServiceExtensions_Set
    {
        static public async Task<UpdateValuesResponse> SetValueRange(this SheetsService item, string id, ValueRange value_range, string range, bool interpret=false)
        {
            SpreadsheetsResource.ValuesResource.UpdateRequest request = item.Spreadsheets.Values.Update(value_range, id, range);

            request.ValueInputOption = interpret.ConvertBool(
                SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED,
                SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW
            );
            return await request.ExecuteAsync();
        }
        static public async Task<UpdateValuesResponse> SetValueRange(this SheetsService item, string id, ValueRange value_range, SheetRange range, bool interpret=false)
        {
            return await item.SetValueRange(id, value_range, range.ToA1(), interpret);
        }

        static public async Task<UpdateValuesResponse> SetValueRow(this SheetsService item, string id, IList<string> row, string range, bool interpret=false)
        {
            return await item.SetValueRange(
                id,
                new ValueRange() {
                    Values = ((IList<object>)row).WrapAsIList(),
                    MajorDimension = "ROWS"
                },
                range,
                interpret
            );
        }
        static public async Task<UpdateValuesResponse> SetValueRow(this SheetsService item, string id, IList<string> row, SheetRange range, bool interpret=false)
        {
            return await item.SetValueRow(id, row, range.ToA1(), interpret);
        }

        static public async Task<UpdateValuesResponse> SetValueCell(this SheetsService item, string id, string value, string range, bool interpret=false)
        {
            return await item.SetValueRow(id, value.WrapAsIList(), range, interpret);
        }
        static public async Task<UpdateValuesResponse> SetValueCell(this SheetsService item, string id, string value, SheetRange range, bool interpret=false)
        {
            return await item.SetValueCell(id, value, range.ToA1(), interpret);
        }
    }
}