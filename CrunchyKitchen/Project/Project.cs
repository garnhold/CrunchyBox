using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public abstract class Project<FILE, DIRECTORY, PROJECT>
        where FILE : ProjectFile<FILE, DIRECTORY, PROJECT>
        where DIRECTORY : ProjectDirectory<FILE, DIRECTORY, PROJECT>
        where PROJECT : Project<FILE, DIRECTORY, PROJECT>
    {
        private StreamSystem stream_system;

        private ProjectItemCreator<FILE> project_file_creator;
        private ProjectItemCreator<DIRECTORY> project_directory_creator;

        private DIRECTORY root;

        protected virtual void UpdateInternal() { }

        public Project(StreamSystem s, ProjectItemCreator<FILE> f, ProjectItemCreator<DIRECTORY> d)
        {
            stream_system = s;

            project_file_creator = f;
            project_directory_creator = d;

            root = project_directory_creator.Create("");
            root.InitializeAsRoot((PROJECT)this);
        }

        public void Update()
        {
            root.Update();

            UpdateInternal();
        }

        public DIRECTORY GetRoot()
        {
            return root;
        }

        public StreamSystem GetStreamSystem()
        {
            return stream_system;
        }

        public ProjectItemCreator<FILE> GetProjectFileCreator()
        {
            return project_file_creator;
        }

        public ProjectItemCreator<DIRECTORY> GetProjectDirectoryCreator()
        {
            return project_directory_creator;
        }
    }
}