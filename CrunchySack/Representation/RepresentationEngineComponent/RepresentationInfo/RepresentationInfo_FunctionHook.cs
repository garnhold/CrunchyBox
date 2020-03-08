using System;

namespace Crunchy.Sack
{
    using Dough;
    using Salt;
    using Noodle;
    
    public class RepresentationInfo_FunctionHook : RepresentationInfo
    {
        private Hook hook;

        private bool PushToRepresentationInternal(CmlValue_Function value, object representation, CmlContext context)
        {
            FunctionSyncro function_syncro = new FunctionSyncro(value.GetFunctionInstance());

            context.AddFunctionSyncro(function_syncro);

            hook.AddDelegate(representation, function_syncro.CreateDelegate(hook.GetHookType()));
            return true;
        }

        public RepresentationInfo_FunctionHook(string n, Hook h) : base(n, h.GetDeclaringType())
        {
            hook = h;
        }
    }
    static public partial class RepresentationEngineExtensions_Add
    {
        static public void AddFunctionHookInfo(this RepresentationEngine item, string n, Hook h)
        {
            item.AddInfo(new RepresentationInfo_FunctionHook(n, h));
        }
        static public void AddFunctionHookInfo(this RepresentationEngine item, Hook h)
        {
            item.AddFunctionHookInfo(h.GetHookName(), h);
        }

        static public void AddFunctionHookInfo<REPRESENTATION_TYPE>(this RepresentationEngine item, string n, string p)
        {
            item.AddFunctionHookInfo(n, typeof(REPRESENTATION_TYPE).GetHookByPath(p));
        }

        static public void AddFunctionInfo<REPRESENTATION_TYPE, DELEGATE_TYPE>(this RepresentationEngine item, string n, Process<REPRESENTATION_TYPE, DELEGATE_TYPE> a)
        {
            item.AddFunctionHookInfo(n,
                new Hook_Operation<REPRESENTATION_TYPE, DELEGATE_TYPE>(n, a, null)
            );
        }
    }
}