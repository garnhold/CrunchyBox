using System;
using System.IO;

using UnityEngine;

using CrunchyDough;
using CrunchyRecipe;

namespace CrunchySandwich
{
    [ExplicitStateSystemType]
    public abstract class StateSystem<T> : Subsystem<T> where T : StateSystem<T>
    {
        private PeriodicWorkScheduler scheduler;
        private string loaded_tyon;

        protected abstract Duration GetAutoSaveInterval();

        public override void Start()
        {
            scheduler = new PeriodicWorkScheduler(
                () => GetAutoSaveInterval(),
                () => SaveState()
            );

            LoadState();
        }

        public override void Update()
        {
            scheduler.Update();
        }

        public void LoadState()
        {
            loaded_tyon = Files.GetStreamSystem().ReadText(GetFilename());

            StateSystemTyonSettings.INSTANCE.CreateContext()
                .DeserializeInto(this, loaded_tyon, TyonHydrationMode.Permissive);
        }

        public void SaveState()
        {
            string new_tyon = StateSystemTyonSettings.INSTANCE.CreateContext()
                .Serialize(this);

            if (new_tyon != loaded_tyon)
            {
                Files.GetStreamSystem().WriteText(GetFilename(), new_tyon);
                loaded_tyon = new_tyon;
            }
        }
        public void ForceSaveState()
        {
            loaded_tyon = null;
            SaveState();
        }

        public string GetFilename()
        {
            return Filename.MakeDataFilename("StateSystem", GetType().GetCleanName());
        }
    }
}