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

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

using Crunchy.Pantry;
using CrunchyPantry_GoogleDrive.GoogleEX;
using CrunchyPantry_GoogleDrive.GoogleEX.Storage;

namespace Crunchy.Pantry_GoogleDrive
{
    static public class RequestErrorExtensions
    {
        static public AttemptResult GetAttemptResult(this Google.Apis.Requests.RequestError item)
        {
            return item.Errors.Convert(delegate(Google.Apis.Requests.SingleError error){
                switch(error.Reason)
                {
                    case "badRequest": return AttemptResult.Failed;
                    case "invalidSharingRequest": return AttemptResult.Failed;
                    case "authError": return AttemptResult.Failed;
                    case "sharingRateLimitExceeded": return AttemptResult.Failed;
                    case "appNotAuthorizedToFile": return AttemptResult.Failed;
                    case "insufficientFilePermissions": return AttemptResult.Failed;
                    case "domainPolicy": return AttemptResult.Failed;
                    case "notFound": return AttemptResult.Failed;

                    case "backendError": return AttemptResult.Failed;
                    case "dailyLimitExceeded": return AttemptResult.Failed;
                    case "userRateLimitExceeded": return AttemptResult.Failed;
                    case "rateLimitExceeded": return AttemptResult.Failed;
                }

                throw new UnaccountedBranchException("error.Reason", error.Reason);
            }).PerformIteratedBinaryOperation((a1, a2) => a1.GetAbsorbed(a2));
        }
    }
}