
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 10/6/2017 11:43:24 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchyRecipe
{
	public partial class TyonValue_Object : TyonValue
	{
        public TyonValue_Object(object value, TyonDehydrater dehydrater) : this()
        {
            SetTyonObject(new TyonObject(value, dehydrater));
        }

        public override void Render(TextDocumentCanvas canvas)
        {
            GetTyonObject().Render(canvas);
        }

        public override void PushToVariable(VariableInstance variable, TyonHydrater hydrater)
        {
            if (variable.GetVariableType().IsTypicalReferenceType())
            {
                object current_value = variable.GetContents();

                if (current_value != null)
                {
                    if (GetTyonObject().GetSystemType(hydrater) == current_value.GetType())
                    {
                        GetTyonObject().PushToSystemObject(current_value, hydrater);
                        return;
                    }
                }
            }

            object value = GetTyonObject().InstanceSystemObject(hydrater);

            hydrater.DeferProcess(delegate() {
                variable.SetContents(value);
            });
        }
	}
}
