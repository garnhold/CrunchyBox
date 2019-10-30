using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;
using CrunchyGinger;
using CrunchySandwich;

namespace CrunchySandwichBag
{
    static public class DeployablePrefabExtensions_Prefabs
    {
        static private CSTextDocumentWriter CreateWriter(this DeployablePrefab item, CSTextDocumentBuilder builder)
        {
            return builder.CreateWriterWithVariablePairs(
                "TYPE", item.GetType().Name,
                "NAME", item.GetPrefabsName(),
                "FUNCTION", ("Deploy_" + item.name).StyleAsFunctionName()
            );
        }
        static private CSTextDocumentWriter CreateWriter(Type item, CSTextDocumentBuilder builder)
        {
            return builder.CreateWriterWithVariablePairs(
                "TYPE", item.Name
            );
        }

        static public void GeneratePrefabsMembers(this DeployablePrefab item, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = item.CreateWriter(builder);

            writer.Write("[SerializeField]private ?TYPE ?NAME;");

            foreach (MethodInfo method in item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize"),
                    Filterer_MethodInfo.IsOriginalMethod()
                ))
            {
                string parameters = method.GetParameters()
                    .Convert(p => p.ParameterType.Name + " " + p.Name)
                    .Join(", ");

                string arguments = method.GetParameters()
                    .Convert(p => p.Name)
                    .Join(", ");

                writer.Write("static public ?TYPE ?FUNCTION(" + parameters + ")", delegate() {
                    writer.Write("return GetInstance().?NAME.Deploy(" + arguments + ");");
                });
            }
        }

        static public void GeneratePrefabsExtensionsMembers(Type item, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = CreateWriter(item, builder);

            foreach (MethodInfo method in item.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize"),
                    Filterer_MethodInfo.IsOriginalMethod()
                ))
            {
                string parameters = method.GetParameters()
                    .Convert(p => p.ParameterType.Name + " " + p.Name)
                    .Prepend("this ?TYPE item")
                    .Join(", ");

                string arguments = method.GetParameters()
                    .Convert(p => p.Name)
                    .Join(", ");

                writer.Write("static public ?TYPE Deploy(" + parameters + ")", delegate() {
                    writer.Write("?TYPE instance = item.SpawnInstance<?TYPE>();");

                    writer.Write("instance.Initialize(" + arguments + ");");
                    writer.Write("return instance;");
                });
            }
        }
    }
}