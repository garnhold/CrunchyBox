using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;

using System.Net;

using Crunchy.Dough;

namespace Crunchy.Dinner
{
    static public class HttpListenerExtensions_Form
    {
        static public async Task<IDictionary<string, string>> ServeAndProcessForm(this HttpListener item, Process<StreamWriter> process)
        {
            while (true)
            {
                HttpListenerContext context = await item.GetContextAsync();

                switch (context.Request.HttpMethod)
                {
                    case "GET":
                        StreamWriter writer = new StreamWriter(context.Response.OutputStream);

                        context.Response.Headers.Set("Content-Type", "text/html");
                        process(writer);
                        await writer.FlushAsync();
                        break;

                    case "POST":
                        return context.Request.InputStream.ReadText()
                            .DecodeUrlDictionary();
                }
            }
        }
    }
}