using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class StowawayFile
    {
        private bool is_active;

        private string src_filename;
        private string dst_directory;

        public StowawayFile(string s, string d)
        {
            is_active = false;

            src_filename = s;
            dst_directory = d;
        }

        public bool IntroduceStowaway()
        {
            RemoveStowaway();

            if (Files.CopyFile(src_filename, GetFilename(), false).IsDesired())
            {
                is_active = true;
                return true;
            }

            return false;
        }

        public void RemoveStowaway()
        {
            if (is_active)
            {
                if(Files.DeleteFile(GetFilename()).IsDesired())
                    is_active = false;
            }
        }

        public string GetFilename()
        {
            return Filename.MakeFilename(dst_directory, src_filename);
        }
    }
}