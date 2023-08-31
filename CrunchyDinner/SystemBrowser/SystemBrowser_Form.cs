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
        static public async Task<IDictionary<string, string>> ServeAndProcessForm(string url, Process<StreamWriter> process)
        {
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
                        using (HttpListenerResponse response = context.Response)
                        {
                            switch (context.Request.HttpMethod)
                            {
                                case "GET":
                                    using (StreamWriter writer = new StreamWriter(response.OutputStream))
                                    {
                                        context.Response.Headers.Set("Content-Type", "text/html");
                                        process(writer);
                                    }
                                    break;

                                case "POST":
                                    IDictionary<string, string> values = context.Request.InputStream
                                        .ReadText()
                                        .DecodeUrlDictionary();

                                    using (StreamWriter writer = new StreamWriter(response.OutputStream))
                                    {
                                        context.Response.Headers.Set("Content-Type", "text/plain");
                                        writer.Write("Done");
                                    }
                                    return values;
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
        static public async Task<IDictionary<string, string>> ServeAndProcessForm(short port, Process<StreamWriter> process)
        {
            return await ServeAndProcessForm("http://localhost:" + port + "/", process);
        }
    }
}