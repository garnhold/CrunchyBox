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
    public class DeployablePrefabsSettings : LibrarySettings
    {
        protected override void GenerateTypeMembers(Type type, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", type.Name
            );

            foreach (MethodInfo method in type.GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize"),
                    Filterer_MethodInfo.IsOriginalMethodOf(type)
                ))
            {
                string parameters = method.GetParameters()
                    .Convert(p => p.ParameterType.Name + " " + p.Name)
                    .Prepend("this ?TYPE item")
                    .Join(", ");

                string arguments = method.GetParameters()
                    .Convert(p => p.Name)
                    .Join(", ");

                writer.Write("static public ?TYPE Deploy(" + parameters + ")", delegate () {
                    writer.Write("?TYPE instance = item.SpawnInstance<?TYPE>();");

                    writer.Write("instance.Initialize(" + arguments + ");");
                    writer.Write("return instance;");
                });
            }
        }

        protected override void GenerateAdditionalObjectMembers(UnityEngine.Object value, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", value.GetType().Name,
                "NAME", value.name.StyleAsVariableName(),
                "FUNCTION", ("Deploy_" + value.name).StyleAsFunctionName()
            );

            foreach (MethodInfo method in value.GetType().GetFilteredInstanceMethods(
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

                writer.Write("static public ?TYPE ?FUNCTION(" + parameters + ")", delegate () {
                    writer.Write("return GetInstance().?NAME.Deploy(" + arguments + ");");
                });
            }
        }

        public override string GetLibraryName()
        {
            return "DeployablePrefabs";
        }

        public override IEnumerable<UnityEngine.Object> GetObjects()
        {
            return Project.GetAllPrefabs<DeployablePrefab>()
                .Convert<DeployablePrefab, UnityEngine.Object>();
        }

        public override IEnumerable<Type> GetTypes()
        {
            return CrunchyNoodle.Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<DeployablePrefab>(),
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
            );
        }
    }
}