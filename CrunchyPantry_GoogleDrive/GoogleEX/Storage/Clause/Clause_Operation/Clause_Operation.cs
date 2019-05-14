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
            public abstract class Clause_Operation : Clause
            {
                protected abstract string CreateInnerQueryString();

                public override string CreateQueryString()
                {
                    return CreateInnerQueryString().Surround("(", ")");
                }
            }
        }
    }
}