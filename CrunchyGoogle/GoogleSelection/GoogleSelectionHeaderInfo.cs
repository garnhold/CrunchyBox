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
        public class HeaderInfo
        {
            private ColumnInfo[] column_infos;

            private Dictionary<ID_ENUM, ColumnInfo> native_id_to_column_info;

            static public HeaderInfo FromJArray(JArray array)
            {
                if (array != null)
                {
                    return new HeaderInfo(
                        array.AsJObjects()
                            .Convert(o => new ColumnInfo(
                                o.GetStringValue("id"),
                                o.GetStringValue("label")
                            ))
                    );
                }

                return null;
            }

            private HeaderInfo(IEnumerable<ColumnInfo> cis)
            {
                column_infos = cis.ToArray();

                native_id_to_column_info = null;
            }

            public Row CreateEmptyRow()
            {
                return new Row(Schema.GetInstance().CreateRowArray());
            }

            public Row CreateRow(IEnumerable<string> values)
            {
                string[] output = Schema.GetInstance()
                    .CreateRowArray();

                int i = 0;
                foreach (string value in values)
                {
                    int index = column_infos[i++].GetIndex();

                    if (index != -1)
                        output[index] = value;
                }

                return new Row(output);
            }
            public Row CreateRow(JArray array)
            {
                if (array != null)
                {
                    return CreateRow(
                        array.AsJObjects()
                            .Convert(o => o.GetStringValue("v"))
                    );
                }

                return null;
            }
            public Row CreateRow(JObject obj)
            {
                if (obj != null)
                    return CreateRow(obj.GetJArrayValue("c"));

                return null;
            }

            public string GetA1IdForNativeId(ID_ENUM id)
            {
                return GetColumnInfoForNativeId(id)
                    .IfNotNull(i => i.GetA1Id());
            }

            public ColumnInfo GetColumnInfoForNativeId(ID_ENUM id)
            {
                if (native_id_to_column_info == null)
                {
                    native_id_to_column_info = column_infos
                        .ToDictionaryValues(i => i.GetNativeId());
                }

                return native_id_to_column_info.GetValue(id);
            }
        }
    }
}