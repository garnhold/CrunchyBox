using System;

namespace UnityOrphanPurger
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string root_filepath = args[0];
            string target_filepath = args[1];

            OrphanPurger purger = new OrphanPurger();

            do
            {
                purger.Clear();
                purger.LoadReferences(root_filepath);
            } while (purger.PurgeOrphans(target_filepath) >= 1);
        }
    }
}
