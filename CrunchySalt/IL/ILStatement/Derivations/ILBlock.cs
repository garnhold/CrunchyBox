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
        private List<ILLocal> locals;

        private List<ILStatement> statements;

        public ILBlock(IEnumerable<ILStatement> s)
        {
            locals = new List<ILLocal>();
            statements = new List<ILStatement>();

            AddStatements(s);
        }

        public ILBlock(params ILStatement[] s) : this((IEnumerable<ILStatement>)s) { }

        public ILBlock(Process<ILBlock> process) : this()
        {
            process(this);
        }

        public ILLocal CreateLocal(Type type, string name, ILValue initial_value, bool is_cemented)
        {
            ILLocal local = locals.AddAndGet(new ILLocal(type, name, initial_value, is_cemented));

            AddStatement(new ILInitializeLocal(local));
            return local;
        }

        public ILLocal CreateLocal(Type type, string name)
        {
            return CreateLocal(type, name, null, false);
        }
        public ILLocal CreateLocal(Type type)
        {
            return CreateLocal(type, null);
        }

        public ILLocal CreateLocal(string name, ILValue value, bool is_cemented)
        {
            return CreateLocal(value.GetValueType(), name, value, is_cemented);
        }
        public ILLocal CreateLocal(ILValue value, bool is_cemented)
        {
            if(is_cemented)
            {
                ILLocal local;

                if (value.Convert<ILLocal>(out local))
                {
                    if (local.IsCemented())
                        return local;
                }
            }

            return CreateLocal(null, value, is_cemented);
        }

        public ILValue CreateTrivial(ILValue value)
        {
            if (value.IsILCostTrivial())
                return value;

            return CreateLocal(value, true);
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
            locals.Process(l => l.Allocate(canvas));

                statements.Process(s => s.RenderIL_Execute(canvas));

            locals.Process(l => l.Release(canvas));
        }

        public override void RenderText_Statement(ILTextCanvas canvas)
        {
            statements.Process(s => s.RenderText_Statement(canvas));
        }

        public IEnumerable<ILLocal> GetLocals()
        {
            return locals;
        }

        public IEnumerable<ILStatement> GetStatements()
        {
            return statements;
        }
    }
}