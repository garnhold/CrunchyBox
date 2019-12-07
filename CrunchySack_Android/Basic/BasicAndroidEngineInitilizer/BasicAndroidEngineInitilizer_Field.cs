using System;
using System.IO;

using Android;
using Android.App;
using Android.Views;
using Android.Widget;

namespace Crunchy.Sack_Android
{
    using Dough;
    using Sack;
    
    [BasicAndroidEngineInitilizer]
    static public class BasicAndroidEngineInitilizer_Field
    {
        [BasicAndroidEngineInitilizer]
        static public void Initilize(AndroidEngine engine)
        {
            engine.Add(
                AndroidInstancers.Simple("TextField", r => {
                    EditText v = new EditText(r);

                    v.TextSize = 12.0f;

                    v.ImeOptions |= Android.Views.InputMethods.ImeAction.Done;
                    v.ImeOptions |= (Android.Views.InputMethods.ImeAction)(Android.Views.InputMethods.ImeFlags.NoExtractUi);
                    v.ImeOptions |= (Android.Views.InputMethods.ImeAction)(Android.Views.InputMethods.ImeFlags.NoFullscreen);
                    return v;
                }),

                AndroidInstancers.Variation<EditText>("StringField", "TextField", v => {
                    v.SetSelectAllOnFocus(true);
                    v.InputType = Android.Text.InputTypes.TextVariationShortMessage;
                }),

                AndroidInstancers.Variation<EditText>("IntField", "StringField", v => v.InputType = Android.Text.InputTypes.ClassNumber),
                AndroidInstancers.Variation<EditText>("FloatField", "StringField", v => v.InputType = Android.Text.InputTypes.ClassNumber | Android.Text.InputTypes.NumberFlagDecimal)
            );
        }
    }
}