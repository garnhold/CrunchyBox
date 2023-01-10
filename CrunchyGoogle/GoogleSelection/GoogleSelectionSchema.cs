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
    public partial class GoogleSelection<ID_ENUM>
    {
        public class Schema
        {
            private EnumInfo enum_info;

            private Dictionary<string, EnumValueInfo> column_label_to_value;

            static private Schema INSTANCE;
            static public Schema GetInstance()
            {
                if (INSTANCE == null)
                    INSTANCE = new Schema();

                return INSTANCE;
            }

            private Schema()
            {
                enum_info = typeof(ID_ENUM).GetEnumInfo();

                column_label_to_value = enum_info.GetEnumValueInfos()
                    .ToDictionaryOverwriteValues(
                        v => v.GetCustomAttributeOfType<ColumnLabel>(true)
                            .IfNotNull(a => a.GetLabel())
                    );
            }

            public string[] CreateRowArray()
            {
                return new string[enum_info.GetMaxEnumValueInfo().GetLongValue() + 1];
            }

            public ID_ENUM GetIdWithCustomAttributeOfType<T>() where T : Attribute
            {
                return enum_info.GetEnumValueInfos()
                    .FindFirst(i => i.HasCustomAttributeOfType<T>(true))
                    .IfNotNull(i => i.GetValue<ID_ENUM>());
            }

            public EnumValueInfo GetEnumValueInfoForColumnLabel(string label)
            {
                return column_label_to_value.GetValue(label);
            }
        }
    }
}