using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyKitchen
{
    public abstract class ProjectItem<FILE, DIRECTORY, PROJECT> : NamedItem, Holdable<DIRECTORY>
        where FILE : ProjectFile<FILE, DIRECTORY, PROJECT>
        where DIRECTORY : ProjectDirectory<FILE, DIRECTORY, PROJECT>
        where PROJECT : Project<FILE, DIRECTORY, PROJECT>
    {
        private string name;

        [HoldingContainer]private HoldingContainer<DIRECTORY> parent_directory;

        public abstract bool IsRoot();
        public abstract string GetPath();

        protected virtual void UpdateInternal() { }
        protected abstract bool RenameInternal(string new_name);

        public ProjectItem(string n)
        {
            name = Filename.CleanFilename(n);
        }

        public void Update()
        {
            if (GetStreamSystem().DoesExist(GetPath()))
                UpdateInternal();
            else
                this.OrphanHoldable();
        }

        public AttemptResult Delete(long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            AttemptResult result = GetStreamSystem().Delete(
                GetPath(),
                milliseconds
            );

            if (result.IsDesired())
                this.OrphanHoldable();

            return result;
        }

        public AttemptResult Rename(string new_name, bool overwrite, long milliseconds = StreamSystem.DEFAULT_WAIT)
        {
            new_name = Filename.CleanFilename(new_name);

            AttemptResult result = GetStreamSystem().Rename(
                GetPath(),
                new_name,
                overwrite,
                milliseconds
            );

            if (result.IsDesired())
            {
                if (RenameInternal(new_name))
                    name = new_name;
                else
                    this.OrphanHoldable();
            }

            return result;
        }

        public string GetName()
        {
            return name;
        }

        public string GetItemLabel()
        {
            return GetName();
        }

        public bool IsOrphan()
        {
            return this.IsOrphanHoldable();
        }

        public bool IsDescendantOf(DIRECTORY directory)
        {
            if (GetParentDirectory() == directory)
                return true;

            return GetParentDirectory().IfNotNull(d => d.IsDescendantOf(directory), false);
        }

        public DIRECTORY GetParentDirectory()
        {
            return this.GetHolder();
        }

        public virtual PROJECT GetProject()
        {
            return GetParentDirectory().IfNotNull(d => d.GetProject());
        }

        public StreamSystem GetStreamSystem()
        {
            return GetProject().IfNotNull(p => p.GetStreamSystem());
        }
    }
}