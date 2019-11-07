using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
    public class TyonSolidObject
    {
        private object target;
        private StreamSystemStream stream;

        private TyonSettings settings;
        private TyonHydrationMode mode;

        private string previous_tyon;

        public TyonSolidObject(object t, StreamSystemStream s, TyonSettings ts, TyonHydrationMode m)
        {
            target = t;
            stream = s;

            settings = ts;
            mode = m;
        }

        public void Load()
        {
            previous_tyon = stream.ReadText();

            settings.CreateContext().DeserializeInto(
                target,
                previous_tyon, 
                mode
            );
        }

        public void Save()
        {
            string current_tyon = settings.CreateContext().Serialize(target);

            if (current_tyon != previous_tyon)
            {
                stream.WriteText(current_tyon);
                previous_tyon = current_tyon;
            }
        }

        public void ForceSave()
        {
            previous_tyon = null;
            Save();
        }
    }
}
