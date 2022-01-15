using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Recipe;
using Crunchy.Sandwich;

namespace Scratch
{
    public class Poop
    {
        [TyonField] public RouletteWheel<string> wheel;
        [TyonField] public List<KeyValuePair<string, float>> stuff;
        [TyonField] public VectorF2 vec;
        [TyonField] public Poop outside;

        public Poop()
        {
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            string tyon = @"
Poop {
    outside = @1;
}

            ";

            object p = new Poop();

            Poop aa = new Poop();

            Process<object, TyonContext> operation = TyonSettings_General.INSTANCE.CompilePushToSystemObject(tyon, TyonHydrationMode.Permissive);

            TyonContext context = TyonSettings_General.INSTANCE.CreateContext(Enumerable.New<object>(aa));

            Console.WriteLine(operation.GetDynamicMethodILBody());

            operation(p, context);

            string tyon2 = TyonSettings_General.INSTANCE.Serialize(p);

            Console.WriteLine(tyon2);

            object deserialized2 = TyonSettings_General.INSTANCE.Deserialize(tyon2, TyonHydrationMode.Strict);

            string tyon3 = TyonSettings_General.INSTANCE.Serialize(deserialized2);

            Console.WriteLine(tyon3);
            Console.ReadLine();
        }

    }
}
