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
        static public void GenerateEditorCode(string filename, Process<CSTextDocumentBuilder> process)
        {
            GenerateCode(Project.GetEditorGeneratedDirectory(), filename, process);
        }

        static public void GenerateEditorClass(string class_name, Process<CSTextDocumentBuilder> process)
        {
            GenerateClass(Project.GetEditorGeneratedDirectory(), class_name, process);
        }

        static public void GenerateEditorCodeFromTypes(string class_base_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateCodeFromTypes(Project.GetEditorGeneratedDirectory(), class_base_name, type, process);
        }
        static public void GenerateEditorCodeFromTypes<T>(string class_base_name, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateEditorCodeFromTypes(class_base_name, typeof(T), process);
        }

        static public void GenerateEditorClassFromTypes(string class_name, Type type, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateClassFromTypes(Project.GetEditorGeneratedDirectory(), class_name, type, process);
        }
        static public void GenerateEditorClassFromTypes<T>(string class_name, Process<Type, CSTextDocumentBuilder> process)
        {
            GenerateEditorClassFromTypes(class_name, typeof(T), process);
        }
    }
}