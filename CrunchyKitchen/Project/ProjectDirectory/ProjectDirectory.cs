using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public abstract class ProjectDirectory<FILE, DIRECTORY, PROJECT> : ProjectItem<FILE, DIRECTORY, PROJECT>, StreamSystemDirectory
        where FILE : ProjectFile<FILE, DIRECTORY, PROJECT>
        where DIRECTORY : ProjectDirectory<FILE, DIRECTORY, PROJECT>
        where PROJECT : Project<FILE, DIRECTORY, PROJECT>
    {
        private HoldingList<DIRECTORY, FILE> files;
        private HoldingList<DIRECTORY, DIRECTORY> directorys;

        private PROJECT project;

        protected override void UpdateInternal()
        {
            string path = GetPath();

            files.AddRange(
                GetStreamSystem().GetStreamNames(path)
                    .Skip(n => files.Has(f => f.GetName() == n))
                    .Convert(n => GetProject().GetProjectFileCreator().Create(n))
                    .SkipNull()
            );

            directorys.AddRange(
                GetStreamSystem().GetDirectoryNames(path)
                    .Convert(n => n.TrimSuffix("/"))
                    .Skip(n => directorys.Has(d => d.GetName() == n))
                    .Convert(n => GetProject().GetProjectDirectoryCreator().Create(n))
                    .SkipNull()
            );

            files.ProcessCopy(f => f.Update());
            directorys.ProcessCopy(d => d.Update());
        }

        protected override bool RenameInternal(string new_name)
        {
            DIRECTORY possible = GetProject().GetProjectDirectoryCreator().Create(new_name);

            if (possible.GetType() == GetType())
                return true;

            GetParentDirectory().AddDirectory(possible);
            return false;
        }

        private AttemptResult Move(ProjectItem<FILE, DIRECTORY, PROJECT> to_move)
        {
            return to_move.GetStreamSystem().Move(
                to_move.GetPath(),
                GetStreamSystem(),
                GetChildPath(to_move.GetName()),
                false
            );
        }

        public ProjectDirectory(string n) : base(n)
        {
            files = new HoldingList<DIRECTORY, FILE>((DIRECTORY)this);
            directorys = new HoldingList<DIRECTORY, DIRECTORY>((DIRECTORY)this);
        }

        public void InitializeAsRoot(PROJECT p)
        {
            project = p;
        }

        public FILE CreateFile(string name)
        {
            FILE file = GetProject().GetProjectFileCreator().Create(name);

            AddFile(file);
            return file;
        }

        public FILE FetchFile(string name)
        {
            return GetFile(name) ?? CreateFile(name);
        }

        public void AddFile(FILE to_add)
        {
            if (to_add != null)
            {
                if (HasFile(to_add.GetName()) == false)
                {
                    if (to_add.IsOrphan())
                        files.Add(to_add);
                    else
                    {
                        if (Move(to_add).IsDesired())
                            files.Add(to_add);
                    }
                }
            }
        }

        public DIRECTORY CreateDirectory(string name)
        {
            DIRECTORY directory = GetProject().GetProjectDirectoryCreator().Create(name);

            AddDirectory(directory);
            return directory;
        }

        public DIRECTORY FetchDirectory(string name)
        {
            return GetDirectory(name) ?? CreateDirectory(name);
        }

        public void AddDirectory(DIRECTORY to_add)
        {
            if (to_add != null && IsDescendantOf(to_add) == false)
            {
                if (HasDirectory(to_add.GetName()) == false)
                {
                    if (to_add.IsOrphan())
                        directorys.Add(to_add);
                    else
                    {
                        if (Move(to_add).IsDesired())
                            directorys.Add(to_add);
                    }
                }
            }
        }

        public string GetChildPath(string name)
        {
            return this.TraverseWithSelf(d => d.GetParentDirectory())
                .Convert(d => d.GetName())
                .Reverse()
                .Append(Filename.CleanFilename(name))
                .Join("/");
        }

        public override bool IsRoot()
        {
            if (project != null)
                return true;

            return false;
        }

        public override string GetPath()
        {
            if (IsRoot())
                return "";

            return GetParentDirectory().GetChildPath(GetName()) + "/";
        }

        public override PROJECT GetProject()
        {
            if (project != null)
                return project;

            return base.GetProject();
        }

        public IEnumerable<FILE> GetFiles()
        {
            return files;
        }

        public bool HasFile(string name)
        {
            if (GetFile(name) != null)
                return true;

            return false;
        }

        public FILE GetFile(string name)
        {
            return files.FindFirst(f => f.GetName() == name);
        }

        public IEnumerable<DIRECTORY> GetDirectorys()
        {
            return directorys;
        }

        public bool HasDirectory(string name)
        {
            if (GetDirectory(name) != null)
                return true;

            return false;
        }

        public DIRECTORY GetDirectory(string name)
        {
            return directorys.FindFirst(d => d.GetName() == name);
        }

        public IEnumerable<object> GetItems()
        {
            return GetDirectorys().Convert<DIRECTORY, object>()
                .Append(GetFiles().Convert<FILE, object>());
        }
    }
}