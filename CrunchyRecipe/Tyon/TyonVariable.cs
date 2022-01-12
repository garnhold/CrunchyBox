
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Recipe
{
    using Dough;
    using Salt;
    using Noodle;
    
    public partial class TyonVariable : TyonElement
	{
        public TyonVariable(VariableInstance variable, TyonDehydrater dehydrater) : this()
        {
            SetId(variable.GetVariable().GetVariableName());
            SetTyonValue(dehydrater.CreateTyonValue(variable.GetVariableType(), variable.GetContents()));
        }

        public void PushToSystemObject(object obj, TyonHydrater hydrater)
        {
            Variable variable;

            if (hydrater.TryGetDesignatedVariable(obj.GetType(), GetId(), out variable))
                GetTyonValue().PushToVariable(variable.CreateStrongInstance(obj), hydrater);
            else
                hydrater.LogMissingField(obj.GetType(), GetId());
        }

        public void CompileInitialize(TyonCompiler compiler)
        {
            GetTyonValue().CompileInitialize(compiler);
        }
        public void CompilePushToSystemObject(ILValue obj, TyonCompiler compiler)
        {
            Variable variable;

            if (compiler.TryGetDesignatedVariable(obj.GetValueType(), GetId(), out variable))
                compiler.AddStatement(variable.CompileSetContents(obj, GetTyonValue().CompileValue(compiler)));
            else
                compiler.LogMissingField(obj.GetValueType(), GetId());
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas)
        {
            canvas.AppendToNewline(GetId());
            canvas.AppendToLine(" = ");
            GetTyonValue().Render(canvas);
            canvas.AppendToLine(";");
        }

        public override string ToString()
        {
            return Render();
        }
	}
	
}
