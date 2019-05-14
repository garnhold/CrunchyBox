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
            public class NameClause : Clause<string>
            { public NameClause(ClauseType_String t, string v) : base("name", t, v) { } }

            public class FullTextClause : Clause<string>
            { public FullTextClause(ClauseType_FullText t, string v) : base("fullText", t, v) { } }

            public class MIMETypeClause : Clause<string>
            { public MIMETypeClause(ClauseType_String t, string v) : base("mimeType", t, v) { } }

            public class IsFileClause : MIMETypeClause
            { public IsFileClause() : base(ClauseType_String.NotEqualTo, Drive.FOLDER_MIME_TYPE) { } }

            public class IsFolderClause : MIMETypeClause
            { public IsFolderClause() : base(ClauseType_String.EqualTo, Drive.FOLDER_MIME_TYPE) { } }

            public class ModifiedDateClause : Clause<DateTime>
            { public ModifiedDateClause(ClauseType_Date t, DateTime v) : base("modifiedDate", t, v) { } }

            public class ViewedByMeDateClause : Clause<DateTime>
            { public ViewedByMeDateClause(ClauseType_Date t, DateTime v) : base("viewedByMeDate", t, v) { } }

            public class TrashedClause : Clause<bool>
            { public TrashedClause(ClauseType_Bool t, bool v) : base("trashed", t, v) { } }

            public class IsTrashedClause : TrashedClause
            { public IsTrashedClause() : base(ClauseType_Bool.EqualTo, true) { } }

            public class IsNotTrashedClause : TrashedClause
            { public IsNotTrashedClause() : base(ClauseType_Bool.EqualTo, false) { } }


            public class StarredClause : Clause<bool>
            { public StarredClause(ClauseType_Bool t, bool v) : base("starred", t, v) { } }

            public class ParentsClause : Clause<string>
            { public ParentsClause(ClauseType_InCollection t, string v) : base("parents", t, v) { } }

            public class OwnersClause : Clause<string>
            { public OwnersClause(ClauseType_InCollection t, string v) : base("owners", t, v) { } }

            public class WritersClause : Clause<string>
            { public WritersClause(ClauseType_InCollection t, string v) : base("writers", t, v) { } }

            public class ReadersClause : Clause<string>
            { public ReadersClause(ClauseType_InCollection t, string v) : base("readers", t, v) { } }

            public class SharedWithMeClause : Clause<bool>
            { public SharedWithMeClause(ClauseType_Bool t, bool v) : base("sharedWithMe", t, v) { } }

            public class VisibilityClause : Clause<string>
            { public VisibilityClause(ClauseType_Enum t, string v) : base("visibility", t, v) { } }
        }
    }
}