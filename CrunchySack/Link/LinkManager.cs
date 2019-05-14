using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;

namespace CrunchySack
{
    public class LinkManager
    {
        private Dictionary<string, List<VariableLink>> variable_links;
        private Dictionary<string, List<EffigyLink>> effigy_links;

        public LinkManager()
        {
            variable_links = new Dictionary<string, List<VariableLink>>();
            effigy_links = new Dictionary<string, List<EffigyLink>>();
        }

        public void Clear()
        {
            variable_links.Clear();
            effigy_links.Clear();
        }

        public void UpdateAll()
        {
            variable_links.Values.Flatten().Process(v => v.Update());
            effigy_links.Values.Flatten().Process(e => e.Update());
        }

        public void Update(string group)
        {
            variable_links.GetValue(group).Process(v => v.Update());

            effigy_links.GetValue(group).Process(e => e.Update());
            effigy_links.Values.Flatten().Process(e => e.UpdateInner(group));
        }

        public void AddVariableLink(string group, VariableLink to_add)
        {
            variable_links.Add(group, to_add);
            to_add.Update();
        }

        public void AddEffigyLink(string group, EffigyLink to_add)
        {
            effigy_links.Add(group, to_add);
            to_add.Update();
        }
    }
}