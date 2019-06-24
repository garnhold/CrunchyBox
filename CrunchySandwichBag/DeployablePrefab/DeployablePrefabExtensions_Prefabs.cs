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
                "STATIC_FUNCTION", ("Deploy_" + item.name).StyleAsFunctionName(),
                "INSTANCE_FUNCTION", ("Spawn_" + item.name + "_Instance").StyleAsFunctionName()
            );

            writer.Write("[SerializeField]private ?TYPE ?NAME;");

            foreach (MethodInfo method in item.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize")
                ))
            {
                string parameters = method.GetParameters().Convert(p => p.ParameterType.Name + " " + p.Name).Join(", ");
                string arguments = method.GetParameters().Convert(p => p.Name).Join(", ");

                writer.Write("public ?TYPE ?INSTANCE_FUNCTION(" + parameters + ")", delegate() {
                    writer.Write("?TYPE instance = ?NAME.SpawnInstance<?TYPE>();");

                    writer.Write("instance.Initialize(" + arguments + ");");
                    writer.Write("return instance;");
                });

                writer.Write("static public ?TYPE ?STATIC_FUNCTION(" + parameters + ")", delegate() {
                    writer.Write("return GetInstance().?INSTANCE_FUNCTION(" + arguments + ");");
                });
            }
        }

        static public string GetPrefabsName(this DeployablePrefab item)
        {
            return item.name.StyleAsVariableName();
        }
    }
}