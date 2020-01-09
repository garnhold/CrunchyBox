using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

using Mono.Cecil;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Pepper;
using Crunchy.Recipe;

namespace UnityExternalIdManager
{
    static class MainClass
    {
        public static void Main(string[] args)
        {
            string filepath = Filename.GetAbsolutePath(args[0]);

            ExternalManager manager = new ExternalManager();

            manager.LoadCurrentTypes(filepath);
            manager.ValidateFiles(filepath);
        }
    }
}
