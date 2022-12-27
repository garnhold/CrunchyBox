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
    public class GoogleApp
    {
        private string app_id;
        private short loopback_port;

        private List<string> scopes;

        public GoogleApp(string ai, short lp, IEnumerable<string> s)
        {
            app_id = ai;
            loopback_port = lp;

            scopes = s.ToList();
        }
        public GoogleApp(string ai, short lp, params string[] s) : this(ai, lp, (IEnumerable<string>)s) { }

        public string GetAppId()
        {
            return app_id;
        }

        public short GetLoopbackPort()
        {
            return loopback_port;
        }

        public IEnumerable<string> GetScopes()
        {
            return scopes;
        }
    }
}