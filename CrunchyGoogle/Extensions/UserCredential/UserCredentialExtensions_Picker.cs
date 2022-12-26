using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using Crunchy.Dough;
using Crunchy.Noodle;
using Crunchy.Dinner;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Crunchy.Google
{
    static public class UserCredentialExtensions_Picker
    {
        static public async Task<string> PickFile(this UserCredential item)
        {
            HttpListener listener = new HttpListener();

            listener.Prefixes.Add("http://localhost:8001/");

            await listener.ServeAndProcessForm(writer => {
                string script = @"
                    function onApiLoad()
                    {
                        gapi.load('picker', () => {
                            const picker = new google.picker.PickerBuilder()
                                .setOAuthToken(" + item.Token.AccessToken.StyleAsSingleQuoteLiteral() + @")
                                .setCallback(data => {
                                    if(data.action == google.picker.Action.PICKED)
                                    {
                                        document
                                            .getElementById(""the_value"")
                                            .value = data.docs[0].id;

                                        document
                                            .getElementById(""the_form"")
                                            .submit();
                                    }
                                });

                            picker
                                .build()
                                .setVisible(true);
                        });
                    }
                ";

                writer.Write(@"
                    <html>
                        <body>
                            <form id=""the_form"">
                                <input type=""hidden"" id=""the_value"" />
                            </form>
                            <script>
                                " + script.EncodeHtmlEntities() + @"
                            </script>
                            <script async defer src=""https://apis.google.com/js/api.js"" onload=""onApiLoad()""></script>
                        </body>
                    </html>
                ");
            });
        }
    }
}