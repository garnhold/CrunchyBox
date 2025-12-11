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
    public partial class GoogleSelection<ID_ENUM> : GoogleSelection, IEnumerable<GoogleSelection<ID_ENUM>.Row> where ID_ENUM : Enum
    {
        private List<Row> rows;
        private HeaderInfo header_info;

        static public GoogleSelection<ID_ENUM> FromGViz(string gviz)
        {
            return FromJson(
                gviz.SubSection(
                    gviz.FindIndexOf("(") + 1,
                    gviz.FindLastIndexOf(")")
                )
            );
        }
        static public GoogleSelection<ID_ENUM> FromJson(string json)
        {
            return FromJObject(JObject.Parse(json));
        }
        static public GoogleSelection<ID_ENUM> FromJObject(JObject obj)
        {
            if (obj != null)
            {
                JObject table = obj.GetValueAsJObject("table");

                if (table != null)
                {
                    JArray cols = table.GetValueAsJArray("cols");
                    JArray rows = table.GetValueAsJArray("rows");

                    if (cols != null && rows != null)
                    {
                        HeaderInfo header = HeaderInfo.FromJArray(cols);

                        return new GoogleSelection<ID_ENUM>(
                            rows.AsJObjects().Convert(o => header.CreateRow(o)),
                            header
                        );
                    }
                }
            }

            return null;
        }

        private GoogleSelection(IEnumerable<Row> r, HeaderInfo h)
        {
            rows = r.ToList();
            header_info = h;
        }

        public IEnumerable<Row> GetRows()
        {
            return rows;
        }

        public HeaderInfo GetHeaderInfo()
        {
            return header_info;
        }

        public IEnumerator<Row> GetEnumerator()
        {
            return rows.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}