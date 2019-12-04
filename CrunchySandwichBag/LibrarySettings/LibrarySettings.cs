using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEditor;

using CrunchyDough;
using CrunchySalt;
using CrunchyGinger;

namespace CrunchySandwichBag
{
    public abstract class LibrarySettings
    {
        public abstract string GetLibraryName();
        public abstract IEnumerable<UnityEngine.Object> GetObjects();

        public virtual IEnumerable<Type> GetTypes() { return Empty.IEnumerable<Type>(); }

        protected virtual void GenerateTypeMembers(Type type, CSTextDocumentBuilder builder) { }
        protected virtual void GenerateAdditionalObjectMembers(UnityEngine.Object value, CSTextDocumentBuilder builder) { }

        private void GenerateObjectMembers(UnityEngine.Object value, CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "NAME", value.name.StyleAsVariableName(),
                "TYPE", value.GetType().ToString(),
                "GET_FUNCTION", ("Get_" + value.name).StyleAsFunctionName()
            );

            writer.Write("[SerializeField]private ?TYPE ?NAME;");
            writer.Write("public ?TYPE ?GET_FUNCTION()", delegate() {
                writer.Write("return ?NAME;");
            });

            GenerateAdditionalObjectMembers(value, builder);
        }

        private void GenerateCode(CSTextDocumentBuilder builder)
        {
            CSTextDocumentWriter writer = builder.CreateWriterWithVariablePairs(
                "CLASS", GetLibraryName(),
                "EXTRA_CLASS", GetLibraryName() + "Extensions"
            );

            writer.Write("public class ?CLASS : CrunchySandwich.Subsystem<?CLASS>", delegate() {
                GetObjects().Process(o => GenerateObjectMembers(o, builder));
            });

            writer.Write("static public class ?EXTRA_CLASS", delegate() {
                GetTypes().Process(t => GenerateTypeMembers(t, builder));
            });
        }

        public void GenerateLibraryClass()
        {
            CodeGenerator.GenerateCode(GetLibraryName(), GenerateCode, GeneratedCodeType.RuntimeDefinition);
        }

        public void InitializeLibraryClass()
        {
            SubsystemExtensions_Asset.GetSubsystemAsset(GetLibraryName())
                .IfNotNull(s => s.ModifyAsset(delegate (SerializedObject obj) {
                    GetObjects().Process(o => 
                        obj.SetChildValue(o.name.StyleAsUnderscoredEntity(), o)
                    );
                }));
        }
    }
}