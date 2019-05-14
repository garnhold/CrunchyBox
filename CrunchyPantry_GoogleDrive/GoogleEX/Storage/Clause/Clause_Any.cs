using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Upload;
using Google.Apis.Download;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyPantry_GoogleDrive
{
    namespace GoogleEX
    {
        namespace Storage
        {
            public class Clause_Any : Clause_Operation_Compound
            {
                public Clause_Any(IEnumerable<Clause> cls) : base("or", cls) { }
                public Clause_Any(params Clause[] cls) : this((IEnumerable<Clause>)cls) { }
            }
        }
    }
}