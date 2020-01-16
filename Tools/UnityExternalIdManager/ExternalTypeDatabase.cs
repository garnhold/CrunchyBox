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

public class ExternalTypeDatabase
{
    [SerializeField] private Dictionary<ExternalTypeReference, ExternalType> types;

    public ExternalTypeDatabase()
    {
        types = new Dictionary<ExternalTypeReference, ExternalType>();
    }

    public void Create(string filepath)
    {
        types = Directory.GetFiles(filepath, "*.dll", SearchOption.AllDirectories)
            .Convert(p => ExternalAssembly.LoadExternalAssembly(p))
            .Convert(a => a.GetExternalTypes())
            .ConvertToValueOfPair(t => t.GetReference())
            .ToDictionaryOverwrite();
    }

    public void Load(string filepath)
    {
        TyonSettings.INSTANCE.DeserializeInto(
            this,
            File.ReadAllText(filepath),
            TyonHydrationMode.Permissive
        );
    }

    public void Save(string filepath)
    {
        File.WriteAllText(
            filepath,
            TyonSettings.INSTANCE.Serialize(this)
        );
    }

    public ExternalType Resolve(ExternalTypeReference reference)
    {
        return types.GetValue(reference);
    }

    public ExternalType Resolve(ExternalTypeReference reference, Operation<ExternalType> operation)
    {
        return types.GetOrCreateValue(reference, operation);
    }

    public IEnumerable<ExternalType> GetTypes()
    {
        return types.Values.SkipNull();
    }
}