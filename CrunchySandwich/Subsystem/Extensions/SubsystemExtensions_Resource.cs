using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    
    static public class SubsystemExtensions_Resource
    {
        static public string GetSubsystemDirectoryResourcePath()
        {
            return "Subsystems/";
        }

        static public string GetSubsystemResourcePath(Type type)
        {
            return GetSubsystemResourcePath(type.Name);
        }
        static public string GetSubsystemResourcePath(string type_name)
        {
            return Filename.MakeFilename(GetSubsystemDirectoryResourcePath(), type_name, "asset");
        }

        static public IEnumerable<Subsystem> LoadSubsystemResources()
        {
            return Resources.LoadAll<Subsystem>(GetSubsystemDirectoryResourcePath());
        }

        static public Subsystem LoadSubsystemResource(Type type)
        {
            return Resources.Load(Filename.GetPathWithoutExtension(GetSubsystemResourcePath(type)), type)
                .Convert<Subsystem>();
        }
    }
}