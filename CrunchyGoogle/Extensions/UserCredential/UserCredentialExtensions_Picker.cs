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
        static public async Task<string> PickFile(this UserCredential item, string app_id, short port)
        {
            IDictionary<string, string> results = await SystemBrowser.ServeAndProcessForm(port, writer => {
                writer.Write(@"
                    <html>
                        <body>
                            <form id=""the_form"" method=""POST"">
                                <input type=""hidden"" id=""the_value"" name=""the_value""/>
                            </form>
                            <script>
                                function onApiLoad()
                                {
                                    gapi.load('picker', () => {
                                        const view = new google.picker.DocsView(google.picker.ViewId.DOCS);

                                        view.setMode(google.picker.DocsViewMode.LIST);
                                        view.setIncludeFolders(true);
                                        view.setParent('root');

                                        const picker = new google.picker.PickerBuilder()
                                            .addView(view)
                                            .setAppId(" + app_id.StyleAsSingleQuoteLiteral() + @")
                                            .setOAuthToken(" + item.Token.AccessToken.StyleAsSingleQuoteLiteral() + @")
                                            .setCallback(data => {
                                                if(data.action == google.picker.Action.PICKED)
                                                {
                                                    document
                                                        .getElementById('the_value')
                                                        .value = data.docs[0].id;

                                                    document
                                                        .getElementById('the_form')
                                                        .submit();
                                                }
                                            });

                                        picker
                                            .build()
                                            .setVisible(true);
                                    });
                                }
                            </script>
                            <script async defer src=""https://apis.google.com/js/api.js"" onload=""onApiLoad()""></script>
                        </body>
                    </html>
                ");
            });

            return results.GetValue("the_value");
        }
        static public async Task<string> PickFile(this UserCredential item, GoogleApp app)
        {
            return await item.PickFile(app.GetAppId(), app.GetLoopbackPort());
        }
    }
}