using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchyKitchen
{
    public abstract class ProjectFile<FILE, DIRECTORY, PROJECT> : ProjectItem<FILE, DIRECTORY, PROJECT>, StreamSystemStream
        where FILE : ProjectFile<FILE, DIRECTORY, PROJECT>
        where DIRECTORY : ProjectDirectory<FILE, DIRECTORY, PROJECT>
        where PROJECT : Project<FILE, DIRECTORY, PROJECT>
    {
        protected override bool RenameInternal(string new_name)
        {
            FILE possible = GetProject().GetProjectFileCreator().Create(new_name);

            if (possible.GetType() == GetType())
                return true;

            GetParentDirectory().AddFile(possible);
            return false;
        }

        public ProjectFile(string n) : base(n)
        {
        }

        public override bool IsRoot()
        {
            return false;
        }

        public override string GetPath()
        {
            return GetParentDirectory().GetChildPath(GetName());
        }
    }
}