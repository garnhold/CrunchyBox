using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

using Mono.Cecil;

using Crunchy.Dough;
using Crunchy.Salt;
using Crunchy.Pepper;
using Crunchy.Recipe;

[AttributeUsage(AttributeTargets.Field)]
public class SerializeFieldAttribute : Attribute
{
}

public class TyonSettings : Crunchy.Recipe.TyonSettings
{
    static public readonly TyonSettings INSTANCE = new TyonSettings();

    private TyonSettings() : base(
        TyonDesignatedVariableProvider_Fields_Marked<SerializeFieldAttribute>.INSTANCE
    ) { }
}