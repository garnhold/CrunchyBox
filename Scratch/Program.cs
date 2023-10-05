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
using Crunchy.Menu;

namespace Scratch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string needle = "public";

            TokenDefinition via_pattern = new TokenDefinition(
                TokenPatterns.String(needle)
            );

            for (int j = 0; j < 6; j++)
            {
                int cost = 1024 * 1024;

                Crunchy.Dough.Timer timer = new Crunchy.Dough.Timer();

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    via_pattern.Detect(needle, 0);
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Pattern");

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    if (needle.IsSubstring(0, needle))
                    {
                        int oup = 0 + needle.Length;
                    }
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Native");

                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(needle);

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    if(needle.RegexIsMatch(regex))
                    {
                        int oup = 0 + needle.Length;
                    }
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Regex");

                Console.WriteLine();
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
