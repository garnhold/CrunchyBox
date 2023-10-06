﻿using System;
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
                TokenPatterns.Sequence(
                    needle.Convert(c => TokenPatterns.Characters(c, 1, 1))
                )
            );

            TokenDefinition via_pattern2 = new TokenDefinition(
                TokenPatterns.OneOrMoreCharacters(
                    TokenCharacterSets.AlphaNumeric(), '_'
                )
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
                    via_pattern2.Detect(needle, 0);
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Pattern2");

                timer.Restart();
                for (int i = 0; i < cost; i++)
                {
                    if (needle.IsSubstring(0, needle))
                    {
                        int oup = 0 + needle.Length;
                    }
                }
                Console.WriteLine(timer.GetElapsedTimeInSeconds() + "s for Native");

                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[A-Za-z0-9_]+");

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
