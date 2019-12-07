using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Kitchen
{
    using Dough;
    using Noodle;
    
    public class ProjectItemCreator_SuffixTypes<ITEM_TYPE> : ProjectItemCreator<ITEM_TYPE>
    {
        private List<KeyValuePair<string, Type>> types;

        public ProjectItemCreator_SuffixTypes(IEnumerable<KeyValuePair<string, Type>> t)
        {
            types = t.Sort(p => -p.Key.Length).ToList();
        }

        public ProjectItemCreator_SuffixTypes(params KeyValuePair<string, Type>[] t) : this((IEnumerable<KeyValuePair<string, Type>>)t) { }

        public override ITEM_TYPE Create(string name)
        {
            return types.FindFirst(p => name.ToLower().EndsWith(p.Key))
                .IfNotNull(p => p.Value.CreateInstance<ITEM_TYPE>(name));
        }
    }
}