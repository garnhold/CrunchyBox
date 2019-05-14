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
            public class Clause_Operation_Unary : Clause_Operation
            {
                private Clause clause;
                private string operation;

                protected override string CreateInnerQueryString()
                {
                    return operation.StyleAsEntity() + " " + clause.CreateQueryString();
                }

                public Clause_Operation_Unary(string o, Clause c)
                {
                    clause = c;
                    operation = o;
                }
            }
        }
    }
}