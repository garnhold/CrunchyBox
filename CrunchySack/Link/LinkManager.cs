using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;
    
    public class LinkManager
    {
        private bool has_initialized;
        private List<VariableValue> variable_values;

        private Dictionary<string, List<VariableLink>> variable_links;
        private Dictionary<string, List<EffigyLink>> effigy_links;

        public LinkManager()
        {
            has_initialized = false;
            variable_values = new List<VariableValue>();

            variable_links = new Dictionary<string, List<VariableLink>>();
            effigy_links = new Dictionary<string, List<EffigyLink>>();
        }

        public void Clear()
        {
            has_initialized = false;
            variable_values.Clear();

            variable_links.Clear();
            effigy_links.Clear();
        }

        public void UpdateAll()
        {
            if (has_initialized == false)
            {
                variable_values.Process(v => v.Initialize());

                has_initialized = true;
            }

            variable_links.Values.Flatten().Process(v => v.Update());
            effigy_links.Values.Flatten().Process(e => e.Update());
        }

        public void Update(string group)
        {
            variable_links.GetValue(group).Process(v => v.Update());

            effigy_links.GetValue(group).Process(e => e.Update());
            effigy_links.Values.Flatten().Process(e => e.UpdateInner(group));
        }

        public void AddVariableValue(VariableValue to_add)
        {
            variable_values.Add(to_add);
        }

        public void AddVariableLink(string group, VariableLink to_add)
        {
            variable_links.Add(group, to_add);
        }

        public void AddEffigyLink(string group, EffigyLink to_add)
        {
            effigy_links.Add(group, to_add);
        }
    }
}