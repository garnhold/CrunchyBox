using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using System.Threading;
using System.Threading.Tasks;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Recipe;
using Crunchy.Sandwich;
using Crunchy.Dinner;

namespace Scratch
{
    class MainClass
    {
        static public async Task DoThing()
        {
            try
            {
                IDictionary<string, string> values = await SystemBrowser.ServeAndProcessForm(1212, writer => {
                    writer.Write(@"
<html>
    <body>
        <form method=""POST"">
            <input type=""text"" name=""poop"" />
            <input type=""submit"" value=""submit"" />
        </form>
    </body>
</html>
                    ");
                });

                values.Process(p => Console.WriteLine(p.Key + " = " + p.Value));
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        public static void Main(string[] args)
        {
            DoThing().Wait();

            Console.ReadLine();
        }

    }
}
