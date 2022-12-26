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
        static void Open(Uri uri)
        {
            if (uri != null)
            {
                if (uri.Scheme == "https" || uri.Scheme == "http")
                {
                    string url = uri.ToString();

                    try
                    {
                        System.Diagnostics.Process.Start(url);
                    }
                    catch
                    {
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                        {
                            System.Diagnostics.Process.Start(
                                new System.Diagnostics.ProcessStartInfo(url.Replace("&", "^&")) { 
                                    UseShellExecute = true 
                                }
                            );
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                        {
                            System.Diagnostics.Process.Start("xdg-open", url);
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                        {
                            System.Diagnostics.Process.Start("open", url);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
        }
        static public void Open(string url)
        {
            Open(new Uri(url));
        }
    }
}