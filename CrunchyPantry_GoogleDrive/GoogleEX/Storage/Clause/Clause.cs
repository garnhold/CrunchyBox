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
            public abstract class Clause<T> : Clause
            {
                private string field;
                private ClauseType<T> type;

                private T value;

                public Clause(string f, ClauseType<T> t, T v)
                {
                    field = f;
                    type = t;

                    value = v;
                }

                public override string CreateQueryString()
                {
                    return type.CreateQueryString(field, value);
                }
            }

            public abstract class Clause
            {
                public abstract string CreateQueryString();
            }
        }
    }
}