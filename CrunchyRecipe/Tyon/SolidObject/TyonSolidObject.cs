using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
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

            if (previous_tyon.IsVisible())
            {
                settings.DeserializeInto(
                    target,
                    previous_tyon,
                    mode
                );
            }
        }

        public void Save()
        {
            string current_tyon = settings.Serialize(target);

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
