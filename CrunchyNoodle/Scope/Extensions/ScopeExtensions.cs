using System;
using System.Collections;
using System.Collections.Generic;

using System.Reflection;

using CrunchyDough;
using CrunchySalt;

namespace CrunchyNoodle
{
    static public class ScopeExtensions
    {
        static public Scope GetParentScope(this Scope item)
        {
            return item.GetParent<Scope>();
        }

        static public IEnumerable<Referenceable> GetLocalReferenceables(this Scope item)
        {
            return item.GetChildren<Referenceable>(c => c.IsNot<Scope>());
        }

        static public IEnumerable<Referenceable> GetLocalReferenceables(this Scope item, string id)
        {
            FieldInfoEX field;

            if (item.GetFilteredInstanceFields(
                Filterer_FieldInfo.CanBeTreatedAs<IDictionary<string, List<Referenceable>>>(),
                Filterer_FieldInfo.HasCustomAttributeOfType<ScopeMapAttribute>()
            ).TryGetFirst(out field))
            {
                IDictionary<string, List<Referenceable>> dictionary = field.GetValue<IDictionary<string, List<Referenceable>>>(item);

                if (dictionary == null)
                {
                    dictionary = new Dictionary<string, List<Referenceable>>();

                    item.GetLocalReferenceables().Process(r => dictionary.Add(r.GetId(), r));
                    field.SetValue(item, dictionary);
                }

                return dictionary.GetValues(id);
            }
            
            return item.GetLocalReferenceables()
                .Narrow(r => id == r.GetId());
        }

        static public IEnumerable<IEnumerable<Referenceable>> GetReferenceables(this Scope item, string id, ScopeAccess access, IList<Scope> path)
        {
            if (item != null)
            {
                yield return item.GetLocalReferenceables(id)
                    .Narrow(r => access.CanAccess(r));

                foreach (Scope scope in item.RetrieveMarkedInstanceValues<Scope, SidewaysScopeAttribute>())
                {
                    path.Add(scope);

                    foreach (IEnumerable<Referenceable> enumerable in scope.GetReferenceables(id, access.GetFromSide(), path))
                        yield return enumerable;

                    path.PopLast();
                }

                if (access == ScopeAccess.Inside)
                {
                    Scope scope = item.GetParentScope();

                    path.Add(scope);

                    foreach (IEnumerable<Referenceable> enumerable in scope.GetReferenceables(id, access.GetFromInside(), path))
                        yield return enumerable;

                    path.PopLast();
                }
            }
        }
        static public IEnumerable<IEnumerable<T>> GetReferenceables<T>(this Scope item, string id, ScopeAccess access, IList<Scope> path)
        {
            return item.GetReferenceables(id, access, path).InnerConvert<Referenceable, T>();
        }
    }
}