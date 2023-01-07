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
        public class Row
        {
            private string[] values;

            public Row(string[] vs)
            {
                values = vs;
            }

            public void SetValue(ID_ENUM id, string value)
            {
                values.SetDropped((int)id.GetLongValue(), value);
            }

            public string GetValue(ID_ENUM id)
            {
                return values.GetDropped((int)id.GetLongValue());
            }

            public IList<string> GetValues()
            {
                return values;
            }
        }
    }
}