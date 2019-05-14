
//-------------------------------
//--Generated Code File----------
//-------------------------------
//Date: 4/13/2017 9:16:12 PM

using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchySalt;
using CrunchyNoodle;

namespace CrunchySack
{
    public partial class CmlInfoSetting : CmlElement, LabeledItem<string>
	{
        private void LoadContextIntermediateValue(string input)
        {
            SetValue(input.ExtractStringValueFromLiteralString());
        }

        public string GetItemLabel()
        {
            return GetName();
        }
	}
	
}
