using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Recipe;

namespace Scratch
{
    public class Poop
    {
        [TyonField] public RouletteWheel<string> wheel;
        [TyonField] public List<KeyValuePair<string, float>> stuff;
        [TyonField] public VectorF2 vec;

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

            p.stuff = new List<KeyValuePair<string, float>>(new KeyValuePair<string, float>[] {
                KeyValuePair.New<string, float>("eeee", 12),
                KeyValuePair.New("helleeeeee", 321.0f)
            });

            //string tyon = TyonSettings_General.INSTANCE.Serialize(p);

            string tyon = @"
Scratch.Poop {
    wheel = [
            KeyValuePair<String,Single>(""hello"", 23),
            System.Collections.Generic.KeyValuePair<System.String,System.Single>(""hello h haha"", 1)
    ];
    stuff = null;
    vec = VectorF2(10.03f, 4);
}

            ";

            Operation<object, TyonContext> operation = TyonSettings_General.INSTANCE.CompileInstanceSystemObject(tyon, TyonHydrationMode.Permissive);

            object deserialized = operation(null);

            string tyon2 = TyonSettings_General.INSTANCE.Serialize(deserialized);

            Console.WriteLine(tyon2);

            Poop deserialized2 = (Poop)TyonSettings_General.INSTANCE.Deserialize(tyon2, TyonHydrationMode.Strict);

            string tyon3 = TyonSettings_General.INSTANCE.Serialize(deserialized2);

            Console.WriteLine(tyon3);
            Console.ReadLine();
        }

    }
}
