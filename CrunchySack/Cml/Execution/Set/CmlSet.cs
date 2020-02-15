using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSet
    {
        private Dictionary<string, CmlSetAttribute> attributes;
        private Dictionary<string, CmlSetChildren> children;

        public CmlSet()
        {
            attributes = new Dictionary<string, CmlSetAttribute>();
            children = new Dictionary<string, CmlSetChildren>();
        }

        public void AddChild(object child)
        {
            AddNamedChild("", child);
        }
        public void SetChildrenLink(VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            SetNamedChildrenLink("", variable_instance, @class, group);
        }

        public void SetAttributeValue(string name, object value)
        {
            attributes.GetOrCreateDefaultValue(name).SetValue(value);
        }
        public void SetAttributeLink(string name, VariableInstance variable_instance, string group)
        {
            attributes.GetOrCreateDefaultValue(name).SetLink(variable_instance, group);
        }

        public void AddNamedChild(string name, object child)
        {
            children.GetOrCreateDefaultValue(name).AddChild(child);
        }
        public void SetNamedChildrenLink(string name, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            children.GetOrCreateDefaultValue(name).SetLink(variable_instance, @class, group);
        }

        public CmlSetChildren GetChildren(string name)
        {
            return children.GetValue(name);
        }
        public CmlSetChildren GetChildren()
        {
            return GetChildren("");
        }

        public CmlSetAttribute GetAttribute(string name)
        {
            return attributes.GetValue(name);
        }
    }
}
