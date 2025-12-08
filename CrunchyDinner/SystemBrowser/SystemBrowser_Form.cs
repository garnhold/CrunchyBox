using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Runtime;
using System.Runtime.InteropServices;

using System.Threading;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;

using System.Net;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public partial class SystemBrowser
    {
        static public async Task<IDictionary<string, string>> ServeAndProcessForm(string url, Process<StreamWriter, string> process)
        {
            string csrf_token = ByteSequence.GenerateCryptographic(32)
                .ToBase64String();

            HttpListener listener = new HttpListener();

            listener.Prefixes.Add(url);
            listener.Start();

            try
            {
                Open(url);

                while (true)
                {
                    HttpListenerContext context = await listener.GetContextAsync();

                    if (context.Request.IsLocal)
                    {
                        if (context.Request.Headers.Get("Origin") == new Uri(url).GetOrigin())
                        {
                            using (HttpListenerResponse response = context.Response)
                            {
                                switch (context.Request.HttpMethod)
                                {
                                    case "GET":
                                        using (StreamWriter writer = new StreamWriter(response.OutputStream))
                                        {
                                            context.Response.Headers.Set("Content-Type", "text/html");
                                            process(writer, "<input type=\"hidden\" name=\"csrf_token\" value=\""+ csrf_token.EncodeHtmlEntities() + "\"/>");
                                        }
                                        break;

                                    case "POST":
                                        IDictionary<string, string> values = context.Request.InputStream
                                            .ReadText()
                                            .DecodeUrlDictionary();
                                            
                                        if (values.GetValue("csrf_token") == csrf_token)
                                        {
                                            using (StreamWriter writer = new StreamWriter(response.OutputStream))
                                            {
                                                context.Response.Headers.Set("Content-Type", "text/plain");
                                                writer.Write("Done");
                                            }
                                            return values;
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            finally
            {
                listener.Stop();
            }
        }
        static public async Task<IDictionary<string, string>> ServeAndProcessForm(ushort port, Process<StreamWriter, string> process)
        {
            return await ServeAndProcessForm("http://localhost:" + port + "/", process);
        }
    }
}