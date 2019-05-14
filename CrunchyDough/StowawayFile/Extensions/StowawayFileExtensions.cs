using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    static public class StowawayFileExtensions
    {
        static public bool CuckooEgg(this StowawayFile item, Process<string> process)
        {
            if (item.IntroduceStowaway())
            {
                process(item.GetFilename());
                return true;
            }

            return false;
        }
    }
}