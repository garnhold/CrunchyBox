using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

namespace Crunchy.SandwichBag
{
    using Dough;
    using Salt;
    using Noodle;
    using Ginger;
    using Sandwich;
    
    public class EphemeralPrefabsSettings : LibrarySettings
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
                    .Convert(p => p.ParameterType.GetCleanName() + " " + p.Name)
                    .Prepend("this ?TYPE item")
                    .Join(", ");

                string arguments = method.GetParameters()
                    .Convert(p => p.Name)
                    .Join(", ");

                writer.Write("static public void Draw(" + parameters + ")", delegate () {
                    writer.Write("EphemeralSystem.Next(item).Initialize(" + arguments + ");");
                });
            }
        }

        protected override void GenerateAdditionalObjectMembers(UnityEngine.Object value, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "TYPE", value.GetType().Name,
                "NAME", value.name.StyleAsVariableName(),
                "FUNCTION", ("Draw_" + value.name).StyleAsFunctionName()
            );

            foreach (MethodInfo method in value.GetType().GetFilteredInstanceMethods(
                    Filterer_MethodInfo.IsNamed("Initialize"),
                    Filterer_MethodInfo.IsOriginalMethod()
                ))
            {
                string parameters = method.GetParameters()
                    .Convert(p => p.ParameterType.GetCleanName() + " " + p.Name)
                    .Join(", ");

                string arguments = method.GetParameters()
                    .Convert(p => p.Name)
                    .Join(", ");

                writer.Write("static public void ?FUNCTION(" + parameters + ")", delegate () {
                    writer.Write("GetInstance().?NAME.Draw(" + arguments + ");");
                });
            }
        }

        public override string GetLibraryName()
        {
            return "EphemeralPrefabs";
        }

        public override IEnumerable<UnityEngine.Object> GetObjects()
        {
            return Project.GetAllPrefabs<EphemeralPrefab>()
                .Convert<EphemeralPrefab, UnityEngine.Object>();
        }

        public override IEnumerable<Type> GetTypes()
        {
            return Types.GetFilteredTypes(
                Filterer_Type.CanBeTreatedAs<EphemeralPrefab>(),
                Filterer_Type.CanBeTreatedAs<MonoBehaviour>()
            );
        }
    }
}