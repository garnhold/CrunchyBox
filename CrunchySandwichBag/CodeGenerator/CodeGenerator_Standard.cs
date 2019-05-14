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
    static public partial class CodeGenerator
    {
        static public void GenerateStandardCode(string filename, Process<CSTextDocumentBuilder> process)
        {
            GenerateCode(Project.GetGeneratedDirectory(), filename, process);
        }

        static public void GenerateStandardClass(string class_name, Process<CSTextDocumentBuilder> process)
        {
            GenerateClass(Project.GetGeneratedDirectory(), class_name, process);
        }

        static public void GenerateStandardCodeFromTypes(string class_base_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateCodeFromTypes(Project.GetGeneratedDirectory(), class_base_name, type, process);
        }
        static public void GenerateStandardCodeFromTypes<T>(string class_base_name, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateStandardCodeFromTypes(class_base_name, typeof(T), process);
        }

        static public void GenerateStandardClassFromTypes(string class_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateClassFromTypes(Project.GetGeneratedDirectory(), class_name, type, process);
        }
        static public void GenerateStandardClassFromTypes<T>(string class_name, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateStandardClassFromTypes(class_name, typeof(T), process);
        }
    }
}