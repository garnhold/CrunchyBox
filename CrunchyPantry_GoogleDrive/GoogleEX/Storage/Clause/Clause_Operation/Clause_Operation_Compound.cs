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

namespace Crunchy.Pantry_GoogleDrive
{
    using Dough;
    using Salt;
    using Noodle;
    
    namespace GoogleEX
    {
        namespace Storage
        {
            public abstract class Clause_Operation_Compound : Clause_Operation
            {
                private string operation;
                private List<Clause> clauses;

                protected override string CreateInnerQueryString()
                {
                    return clauses
                        .Convert(c => c.CreateQueryString())
                        .Join(" " + operation.StyleAsEntity() + " ");
                }

                public Clause_Operation_Compound(string o, IEnumerable<Clause> c)
                {
                    operation = o;
                    clauses = c.ToList();
                }

                public Clause_Operation_Compound(string o, params Clause[] c) : this(o, (IEnumerable<Clause>)c) { }
            }
        }
    }
}