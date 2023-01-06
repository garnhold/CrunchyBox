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
        public class ColumnInfo
        {
            private string a1_id;
            private string label;

            private EnumValueInfo enum_value_info;

            public ColumnInfo(string i, string l)
            {
                a1_id = i;
                label = l;

                enum_value_info = Schema.GetInstance()
                    .GetEnumValueInfoForColumnLabel(label);
            }

            public string GetA1Id()
            {
                return a1_id;
            }

            public string GetLabel()
            {
                return label;
            }

            public ID_ENUM GetNativeId()
            {
                return enum_value_info
                    .IfNotNull(i => i.GetValue<ID_ENUM>());
            }

            public int GetIndex()
            {
                return (int)enum_value_info
                    .IfNotNull(i => i.GetLongValue());
            }

            public EnumValueInfo GetEnumValueInfo()
            {
                return enum_value_info;
            }
        }
    }
}