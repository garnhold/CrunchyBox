
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: December 26 2021 14:56:14 -08:00

using System;
using System.Collections;
using System.Collections.Generic;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Noodle;

namespace Crunchy.Recipe
{
	public partial class TyonValueList : TyonElement
	{
        public TyonValueList(Type element_type, IEnumerable<object> values, TyonDehydrater dehydrater) : this()
        {
            SetTyonValues(values.Convert(v => dehydrater.CreateTyonValue(element_type, v)));
        }

        public string Render()
        {
            TextDocumentCanvas canvas = new TextDocumentCanvas();

            Render(canvas, true);
            return canvas.ToString();
        }

        public void Render(TextDocumentCanvas canvas, bool multiline)
        {
            GetTyonValues().ProcessWithInterleaving(
                v => v.Render(canvas), 
                () => {
                    canvas.AppendToLine(", ");

                    if (multiline)
                        canvas.AppendNewline();
                }
            );
        }

        public void PushToLogVariable(Variable variable, TyonHydrater hydrater)
        {
            GetTyonValues().ProcessWithIndex((i, v) => v.PushToVariable(variable.CreateStrongInstance(i), hydrater));
        }

        public void CompileInitialization(TyonCompiler compiler)
        {
            GetTyonValues().Process(v => v.CompileInitialize(compiler));
        }

        public IEnumerable<ILValue> CompileValues(TyonCompiler compiler)
        {
            return GetTyonValues().Convert(v => v.CompileValue(compiler));
        }

        public int GetNumberTyonValues()
        {
            return tyon_values.Count;
        }

        public override string ToString()
        {
            return Render();
        }
    }
}
