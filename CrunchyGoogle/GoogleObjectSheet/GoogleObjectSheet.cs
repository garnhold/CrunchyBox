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
using Google.Apis.Sheets.v4;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    public partial class GoogleObjectSheet<ID_ENUM> : GoogleObjectSheet where ID_ENUM : Enum
    {
        private ID_ENUM index_id;
        private GoogleSelection<ID_ENUM>.Sheet sheet;

        public GoogleObjectSheet(GoogleSelection<ID_ENUM>.Sheet s)
        {
            index_id = GoogleSelection<ID_ENUM>.Schema.GetInstance()
                .GetIdWithCustomAttributeOfType<GoogleObjectSheet.IdColumnAttribute>();

            sheet = s;
        }

        public async Task<GoogleSelection<ID_ENUM>.Row> CreateEmptyRow()
        {
            return await sheet.CreateEmptyRow();
        }

        public async Task InsertUpdate(GoogleSelection<ID_ENUM>.Row row)
        {
            string index = row.GetValue(index_id);

            row.SetValue(index_id, "=ROW()-1");
            if (index.IsBlank())
                await sheet.Insert(row, false);
            else
                await sheet.Update(index.ParseInt(), row, false);
        }

        public async Task<GoogleSelection<ID_ENUM>> Select(GoogleSelection<ID_ENUM>.Query query)
        {
            return await sheet.Select(query);
        }
    }
}