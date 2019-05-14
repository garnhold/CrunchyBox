using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;

namespace CrunchySandwich
{
    static public class SubsystemExtensions_Resource
    {
        static public string GetSubsystemDirectoryResourcePath()
        {
            return "Subsystems/";
        }

        static public string GetSubsystemResourcePath(Type type)
        {
            return Filename.MakeFilename(GetSubsystemDirectoryResourcePath(), type.Name, "asset");
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