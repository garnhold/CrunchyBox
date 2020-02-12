using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Sack
{
    using Dough;
    using Noodle;

    public class CmlSet
    {
        private CmlSetChildren children;
        private Dictionary<string, CmlSetAttribute> attributes;
        private Dictionary<string, CmlSetChildren> attribute_children;

        public CmlSet()
        {
            children = new CmlSetChildren();
            attributes = new Dictionary<string, CmlSetAttribute>();
            attribute_children = new Dictionary<string, CmlSetChildren>();
        }

        public void AddChild(object child)
        {
            children.AddChild(child);
        }
        public void SetChildrenLink(VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            children.SetLink(variable_instance, @class, group);
        }

        public void SetAttribute(string name, object value)
        {
            attributes.GetOrCreateDefaultValue(name).SetValue(value);
        }
        public void SetAttributeLink(string name, VariableInstance variable_instance, string group)
        {
            attributes.GetOrCreateDefaultValue(name).SetLink(variable_instance, group);
        }

        public void AddAttributeChild(string name, object child)
        {
            attribute_children.GetOrCreateDefaultValue(name).AddChild(child);
        }
        public void SetAttributeChildrenLink(string name, VariableInstance variable_instance, EffigyClassInfo @class, string group)
        {
            attribute_children.GetOrCreateDefaultValue(name).SetLink(variable_instance, @class, group);
        }

        public CmlSetChildren GetChildren()
        {
            return children;
        }

        public CmlSetAttribute GetAttribute(string name)
        {
            return attributes.GetValue(name);
        }

        public CmlSetChildren GetAttributeChildren(string name)
        {
            return attribute_children.GetValue(name);
        }
    }
}
