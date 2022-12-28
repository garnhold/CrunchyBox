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
        static public async Task<UpdateValuesResponse> SetRawValueRange(this SheetsService item, string id, ValueRange value_range, string range)
        {
            SpreadsheetsResource.ValuesResource.UpdateRequest request = item.Spreadsheets.Values.Update(value_range, id, range);

            request.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.RAW;
            return await request.ExecuteAsync();
        }

        static public async Task<UpdateValuesResponse> SetRawValueRow(this SheetsService item, string id, IList<object> row, string range)
        {
            return await item.SetRawValueRange(
                id,
                new ValueRange() {
                    Values = row.WrapAsIList(),
                    MajorDimension = "ROWS"
                },
                range
            );
        }

        static public async Task<UpdateValuesResponse> SetRawValueCell(this SheetsService item, string id, object value, string range)
        {
            return await item.SetRawValueRow(id, value.WrapAsIList(), range);
        }
    }
}