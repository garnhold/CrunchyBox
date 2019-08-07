using System;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class GeneratedCodeTypeExtensions
    {
        static public bool IsDefinition(this GeneratedCodeType item)
        {
            switch (item)
            {
                case GeneratedCodeType.RuntimeDefinition: return true;
                case GeneratedCodeType.RuntimeLeaf: return false;

                case GeneratedCodeType.EditorOnlyDefinition: return true;
                case GeneratedCodeType.EditorOnlyLeaf: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public bool IsLeaf(this GeneratedCodeType item)
        {
            if (item.IsDefinition() == false)
                return true;

            return false;
        }

        static public bool IsRuntime(this GeneratedCodeType item)
        {
            switch (item)
            {
                case GeneratedCodeType.RuntimeDefinition: return true;
                case GeneratedCodeType.RuntimeLeaf: return true;

                case GeneratedCodeType.EditorOnlyDefinition: return false;
                case GeneratedCodeType.EditorOnlyLeaf: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
        static public bool IsEditorOnly(this GeneratedCodeType item)
        {
            if (item.IsRuntime() == false)
                return true;

            return false;
        }

        static public string GetDirectory(this GeneratedCodeType item)
        {
            switch (item)
            {
                case GeneratedCodeType.RuntimeDefinition: return Project.GetGeneratedDirectory();
                case GeneratedCodeType.RuntimeLeaf: return Project.GetGeneratedLeafDirectory();

                case GeneratedCodeType.EditorOnlyDefinition: return Project.GetEditorGeneratedDirectory();
                case GeneratedCodeType.EditorOnlyLeaf: return Project.GetEditorGeneratedLeafDirectory();
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}