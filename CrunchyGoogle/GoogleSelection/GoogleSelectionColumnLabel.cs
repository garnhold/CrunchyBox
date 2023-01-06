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
    public partial class GoogleSelection
    {
        [AttributeUsage(AttributeTargets.Field)]
        public class ColumnLabel : Attribute
        {
            private string label;

            public ColumnLabel(string l)
            {
                label = l;
            }

            public string GetLabel()
            {
                return label;
            }
        }
    }
}