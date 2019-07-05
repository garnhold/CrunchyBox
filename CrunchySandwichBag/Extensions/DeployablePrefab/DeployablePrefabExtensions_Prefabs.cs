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
        static public void PushPrefabToPrefabs(this DeployablePrefab item, SerializedObject obj)
        {
            obj.SetChildValue(item.GetPrefabsName(), item);
        }

        static public void GeneratePrefabsMembers(this DeployablePrefab item, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", item.GetType().Name,
                "NAME", item.GetPrefabsName(),
                "FUNCTION", ("Deploy_" + item.name).StyleAsFunctionName()
            );

            writer.Write("[SerializeField]private ?TYPE ?NAME;");

            foreach (MethodInfo method in item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize")
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
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", item.Name
            );

            foreach (MethodInfo method in item.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize")
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

        static public void GeneratePrefabsYieldReturn(this DeployablePrefab item, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "NAME", item.GetPrefabsName()
            );

            writer.Write("yield return GetInstance().?NAME;");
        }

        static public string GetPrefabsName(this DeployablePrefab item)
        {
            return item.name.StyleAsVariableName();
        }
    }
}