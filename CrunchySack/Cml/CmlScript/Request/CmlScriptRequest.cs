
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: November 29 2018 15:09:21 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    using Sodium;
    
    public class CmlScriptRequest : CmlScriptValue
    {
        private CmlContext context;

        private List<CmlScriptValue_Argument> arguments;
        private Dictionary<string, CmlScriptValue> indirect_values;

        private CmlScriptValue_Argument this_argument;
        private CmlScriptValue_Argument_Host host_argument;

        private CmlScriptValue_Argument parent_argument;
        private Dictionary<Type, CmlScriptValue_Argument> parent_of_type_arguments;

        private CmlScriptValue_Argument this_representation_argument;
        private Dictionary<string, CmlScriptValue> insert_representation_values;

        public CmlScriptRequest(CmlContext c)
        {
            context = c;

            arguments = new List<CmlScriptValue_Argument>();
            indirect_values = new Dictionary<string, CmlScriptValue>();

            this_argument = AddPrimaryArgument(new CmlScriptValue_Argument_Single_Constant(context.GetTargetInfo().GetTarget()));
            host_argument = AddPrimaryArgument(new CmlScriptValue_Argument_Host());

            parent_argument = null;
            parent_of_type_arguments = new Dictionary<Type, CmlScriptValue_Argument>();

            this_representation_argument = null;
            insert_representation_values = new Dictionary<string, CmlScriptValue>();
        }

        public void AddPrimaryArgument(CmlScriptValue_Argument to_add)
        {
            arguments.Add(to_add);

            to_add.Initialize(
                new ILVirtualParameter(
                    to_add.GetValueType(),
                    arguments.GetFinalIndex()
                )
            );
        }
        public T AddPrimaryArgument<T>(T to_add) where T : CmlScriptValue_Argument
        {
            AddPrimaryArgument((CmlScriptValue_Argument)to_add);

            return to_add;
        }

        public CmlScriptValue_Argument AddSecondaryArgument(CmlScriptValue_Argument to_add)
        {
            return host_argument.AddArgument(to_add);
        }

        public void AddExplicitIndirectValue(string id, CmlScriptValue value)
        {
            indirect_values.Add(id, value);
        }

        public override Type GetValueType()
        {
            return this_argument.GetValueType();
        }

        public override ILValue GetILValue()
        {
            return this_argument.GetILValue();
        }

        public override CmlScriptValue GetIndirectValue(string id)
        {
            return indirect_values.GetOrCreateValue(id, delegate() {
                return (target_info.GetEngine().GetGlobalLibrary()
                    .CreateScriptValue(id, host_argument) ?? this_argument.GetIndirectValue(id));
            });
        }

        public override CmlScriptValue GetIndirectMethodInvokation(string id, IEnumerable<CmlScriptValue> values)
        {
            return this_argument.GetIndirectMethodInvokation(id, values);
        }

        public CmlScriptValue GetParentValue()
        {
            if (parent_argument == null)
            {
                parent_argument = target_info.GetImmediateParent()
                    .IfNotNull(p => AddSecondaryArgument(new CmlScriptValue_Argument_Single_Constant(p)));
            }

            return parent_argument;
        }

        public CmlScriptValue GetParentOfTypeValue(Type type)
        {
            return parent_of_type_arguments.GetOrCreateValue(type, delegate() {
                return target_info.GetParentOfType(type)
                    .IfNotNull(p => AddSecondaryArgument(new CmlScriptValue_Argument_Single_Constant(p)));
            });
        }

        public CmlScriptValue InsertThisRepresentationValue()
        {
            if (this_representation_argument == null)
            {
                this_representation_argument = call_context.GetRepresentationSpace()
                    .IfNotNull(s => s.GetThisRepresentation())
                    .IfNotNull(r => AddSecondaryArgument(new CmlScriptValue_Argument_Single_Constant(r)));
            }

            return this_representation_argument;
        }

        public CmlScriptValue InsertRepresentationValue(string id)
        {
            return insert_representation_values.GetOrCreateValue(id, delegate() {
                return call_context.GetRepresentationSpace()
                    .IfNotNull(s => s.GetRepresentation(id))
                    .IfNotNull(r => AddSecondaryArgument(new CmlScriptValue_Argument_Single_Constant(r)));
            });
        }

        public CmlTargetInfo GetTargetInfo()
        {
            return target_info;
        }

        public CmlScriptValue_Argument GetThisArgument()
        {
            return this_argument;
        }

        public CmlScriptValue_Argument_Host GetHostArgument()
        {
            return host_argument;
        }

        public CmlScriptSignature GetSignature()
        {
            return new CmlScriptSignature(GetArguments().Convert(a => a.GetParameter()));
        }

        public IEnumerable<CmlScriptValue_Argument> GetArguments()
        {
            return arguments;
        }
    }
}
