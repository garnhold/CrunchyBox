using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Recipe;

namespace Scratch
{
    public class Poop
    {
        [TyonField] public RouletteWheel<string> wheel;
        [TyonField] public List<KeyValuePair<string, float>> stuff;

        public Poop()
        {
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Poop p = new Poop();

            p.wheel = new RouletteWheel<string>(
                KeyValuePair.New("hello", 2.0f),
                KeyValuePair.New("hello hahaha", 1.0f)
            );

            p.wheel.GetRoulette().Deconstruct().Process(r => Console.WriteLine(r.Key));

            string tyon = TyonSettings_General.INSTANCE.Serialize(p);

            Console.WriteLine(tyon);

            Poop deserialized = (Poop)TyonSettings_General.INSTANCE.Deserialize(tyon, TyonHydrationMode.Strict);

            Console.WriteLine(TyonSettings_General.INSTANCE.Serialize(deserialized));
            Console.ReadLine();
        }

    }
}
