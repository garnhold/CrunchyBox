using System;
using System.IO;
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

using Newtonsoft.Json.Linq;

namespace Scratch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Issue.Layer<Issue>(() => {
            


                Issue.GetIssues<Issue>();
            });

            JArray array = new JArray();

            List<string> lines = File.ReadAllLines("/home/garrett/Documents/Programming/SliderPuzzleGenerator/6x6SliderPuzzles.txt")
                .ToList();

            Dictionary<int, List<string>> puzzles = new Dictionary<int, List<string>>();

            foreach (string line in lines)
            {
                line.SplitOn("-").PartOut(out string difficulty, out string remainder);

                if (puzzles.GetValue(difficulty.ParseInt()).Count() < 100)
                    puzzles.Add(difficulty.ParseInt(), remainder);
            }

            foreach (KeyValuePair<int, List<string>> pair in puzzles.Sort(p => p.Key))
            {
                array.Add(new JObject(
                    new JProperty("rating", pair.Key),
                    new JProperty("puzzles", pair.Value.Convert(s => new JValue(s)).ToJArray())
                ));
            }

            string filename = Filename.GetAbsolutePath("output.json");

            Console.WriteLine(filename);
            File.WriteAllText(filename, array.ToString());

            Console.WriteLine("Done");
            Console.ReadLine();
        }

    }
}
