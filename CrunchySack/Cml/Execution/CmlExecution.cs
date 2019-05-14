using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public class CmlExecution
    {
        private CmlTargetInfo target_info;
        
        private LinkManager link_manager;
        private SyncroManager syncro_manager;

        private List<CmlCallContext> call_stack;

        public CmlExecution(CmlTargetInfo t, LinkManager l, SyncroManager s)
        {
            target_info = t;
            
            link_manager = l;
            syncro_manager = s;

            call_stack = new List<CmlCallContext>();
            call_stack.Add(new CmlCallContext(null, null, null, null));
        }

        public CmlExecution(CmlTargetInfo t) : this(t, new LinkManager(), new SyncroManager()) { }

        public CmlCallContext CreateNewCallContext(CmlEntry_Class @class, CmlReturnSpace return_space, CmlParameterSpace parameter_space, CmlRepresentationSpace representation_space)
        {
            return new CmlCallContext(
                @class ?? GetCallContext().GetClass(),
                return_space ?? GetCallContext().GetReturnSpace(),
                parameter_space ?? GetCallContext().GetParameterSpace(),
                representation_space ?? GetCallContext().GetRepresentationSpace()
            );
        }

        public void PushPopCallContext(CmlCallContext call_context, Process process)
        {
            call_stack.Add(call_context);
                process();
            call_stack.PopLast();
        }

        public void PushPopClass(CmlEntry_Class @class, Process process)
        {
            PushPopCallContext(
                CreateNewCallContext(@class, null, null, null),
                process
            );
        }

        public void PushPopReturnSpace(CmlReturnSpace return_space, Process process)
        {
            PushPopCallContext(
                CreateNewCallContext(null, return_space, null, null),
                process
            );
        }
        public void PushPopReturnSpaceNew(Process<CmlReturnSpace> process)
        {
            CmlReturnSpace return_space = new CmlReturnSpace();

            PushPopReturnSpace(return_space, delegate() {
                process(return_space);
            });
        }

        public void PushPopParameterSpace(CmlParameterSpace parameter_space, Process process)
        {
            PushPopCallContext(
                CreateNewCallContext(null, null, parameter_space, null),
                process
            );
        }
        public void PushPopParameterSpace(IEnumerable<CmlParameter> parameters, Process process)
        {
            PushPopParameterSpace(
                new CmlParameterSpace(parameters),
                process
            );
        }

        public void PushPopRepresentationSpace(CmlRepresentationSpace representation_space, Process process)
        {
            PushPopCallContext(
                CreateNewCallContext(null, null, null, representation_space),
                process
            );
        }
        public void PushPopRepresentationSpaceNew(Process process)
        {
            PushPopRepresentationSpace(
                new CmlRepresentationSpace(),
                process
            );
        }

        public void AddVariableLink(string group, VariableLink variable_link)
        {
            link_manager.AddVariableLink(group, variable_link);
        }

        public void AddEffigyLink(string group, EffigyLink effigy_link)
        {
            link_manager.AddEffigyLink(group, effigy_link);
        }

        public void AddFunctionSyncro(FunctionSyncro function_syncro)
        {
            function_syncro.SetManager(syncro_manager);
        }

        public CmlTargetInfo GetTargetInfo()
        {
            return target_info;
        }

        public LinkManager GetLinkManager()
        {
            return link_manager;
        }

        public SyncroManager GetSyncroManager()
        {
            return syncro_manager;
        }

        public CmlCallContext GetCallContext()
        {
            return call_stack.GetLast();
        }
    }
}