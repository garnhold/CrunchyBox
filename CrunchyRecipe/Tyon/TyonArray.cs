
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: October 09 2017 18:07:15 -07:00

using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonArray : TyonElement
	{
        public TyonArray(Type element_type, object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonType(TyonType.CreateTyonType(element_type));
            SetTyonValueList(new TyonValueList(element_type, value.ToEnumerable<object>(), dehydrater));
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            GetTyonType().IfNotNull(t => t.Render(canvas));
            canvas.AppendToLine(" [");
            canvas.Indent();
                canvas.AppendNewline();
                GetTyonValueList().IfNotNull(l => l.Render(canvas, true));
            canvas.Dedent();
            canvas.AppendToNewline("]");
        }

        public TyonPushResult PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            Type log_type = GetLogSystemType(hydrater);
            Variable_IndexedLog log = Variable_IndexedLog.New(log_type);

            if (variable.GetContents() != null)
            {
                int index = 0;
                foreach (object old_element in variable.GetContents().Convert<IEnumerable>())
                    log.CreateStrongInstance(index++).SetContents(old_element);
            }

            TyonPushResult push_result = GetTyonValueList().IfNotNull(l => l.PushToLogVariable(log, hydrater));

            Process process = delegate () {
                List<object> values = log.GetValues()
                    .Truncate(GetNumberTyonValues())
                    .ToList();

                Type final_type = IsExplicitlyTyped().ConvertBool(
                    () => log_type,
                    () => values.Convert(v => v.GetTypeEX()).GetCommonAncestor()
                );

                variable.SetContents(values.ToArrayOfType(final_type));
            };

            switch (push_result)
            {
                case TyonPushResult.Done: process(); return TyonPushResult.Done;
                case TyonPushResult.Deferred: hydrater.DeferProcess(process); return TyonPushResult.Deferred;
            }

            throw new UnaccountedBranchException("push_result", push_result);
        }

        public void CompileInitialize(TyonCompiler compiler)
        {
            GetTyonValueList().IfNotNull(l => l.CompileInitialization(compiler));
        }

        public ILValue CompileValue(TyonCompiler compiler)
        {
            List<ILValue> values = GetTyonValueList()
                .IfNotNull(l => l.CompileValues(compiler))
                .ToList();

            Type element_type = IsExplicitlyTyped().ConvertBool(
                () => GetTyonType().GetSystemType(compiler),
                () => values.Convert(v => v.GetValueType()).GetCommonAncestor()
            );

            return new ILNewPopulatedArray(element_type, values);
        }

        public bool IsExplicitlyTyped()
        {
            if (GetTyonType() != null)
                return true;

            return false;
        }
        public bool IsImplicitlyTyped()
        {
            if (IsExplicitlyTyped() == false)
                return true;

            return false;
        }

        public int GetNumberTyonValues()
        {
            return GetTyonValueList().IfNotNull(l => l.GetNumberTyonValues(), 0);
        }

        public Type GetLogSystemType(TyonHydrater hydrater)
        {
            if (IsExplicitlyTyped())
                return GetTyonType().GetSystemType(hydrater);

            return typeof(object);
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
