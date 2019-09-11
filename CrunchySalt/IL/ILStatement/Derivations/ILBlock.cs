using System;
using System.Text;
using System.Reflection;
using System.Reflection.Emit;

using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchySalt
{
    public class ILBlock : ILStatement
    {
        private Dictionary<string, ILLocal> named_locals;
        private List<ILLocal> unamed_locals;
        private List<ILLocal> cemented_locals;

        private List<ILStatement> statements;

        public ILBlock(IEnumerable<ILStatement> s)
        {
            named_locals = new Dictionary<string, ILLocal>();
            unamed_locals = new List<ILLocal>();
            cemented_locals = new List<ILLocal>();
            
            statements = new List<ILStatement>();

            AddStatements(s);
        }

        public ILBlock(params ILStatement[] s) : this((IEnumerable<ILStatement>)s) { }

        public ILBlock(Process<ILBlock> process) : this()
        {
            process(this);
        }

        public ILLocal CreateNamedLocal(Type type, string name, ILValue initial_value = null)
        {
            return named_locals.AddAndGet(name, new ILLocal(type, name, initial_value, false))
                .Chain(l => AddStatement(new ILInitializeLocal(l)));
        }

        public ILLocal CreateUnamedLocal(Type type, ILValue initial_value = null)
        {
            return unamed_locals.AddAndGet(new ILLocal(type, null, initial_value, false))
                .Chain(l => AddStatement(new ILInitializeLocal(l)));
        }

        public ILLocal CreateCementedLocal(ILValue value)
        {
            ILLocal local;

            if (value.Convert<ILLocal>(out local))
            {
                if (local.IsCemented())
                    return local;
            }

            return cemented_locals.AddAndGet(new ILLocal(value.GetValueType(), null, value, true))
                .Chain(l => AddStatement(new ILInitializeLocal(l)));
        }

        public ILValue CreateTrivial(ILValue value)
        {
            if (value.IsILCostTrivial())
                return value;

            return CreateCementedLocal(value);
        }

        public void AddStatement(ILStatement to_add)
        {
            if (to_add == null)
                throw new ArgumentNullException("to_add");

            statements.Add(to_add);
        }
        public void AddStatements(IEnumerable<ILStatement> to_add)
        {
            to_add.Process(s => AddStatement(s));
        }
        public void AddStatements(params ILStatement[] to_add)
        {
            AddStatements((IEnumerable<ILStatement>)to_add);
        }

        public override void RenderIL_Execute(ILCanvas canvas)
        {
            GetLocals().Process(l => l.Allocate(canvas));

                statements.Process(s => s.RenderIL_Execute(canvas));

            GetLocals().Process(l => l.Release(canvas));
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            statements.Process(s => s.RenderText_Statement(canvas));
        }

        public bool TryGetNamedLocal(string name, out ILLocal local)
        {
            return named_locals.TryGetValue(name, out local);
        }
        public ILLocal GetNamedLocal(string name)
        {
            ILLocal local;

            TryGetNamedLocal(name, out local);
            return local;
        }

        public IEnumerable<ILLocal> GetLocals()
        {
            return named_locals.Values
                .Append(unamed_locals)
                .Append(cemented_locals);
        }

        public IEnumerable<ILStatement> GetStatements()
        {
            return statements;
        }
    }
}