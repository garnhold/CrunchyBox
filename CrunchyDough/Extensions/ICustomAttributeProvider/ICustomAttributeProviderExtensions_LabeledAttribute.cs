using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
	static public class ICustomAttributeProviderExtensions_LabeledAttribute
    {
		static public bool HasCustomLabeledAttributeOfType(this ICustomAttributeProvider item, Type attribute_type, string label, bool inherit)
        {
            return item.HasCustomAttributeOfSubType<LabeledAttribute>(attribute_type, inherit, it => it.IsLabeled(label));
        }
        static public bool HasCustomLabeledAttributeOfType<T>(this ICustomAttributeProvider item, string label, bool inherit) where T : LabeledAttribute
        {
            return item.HasCustomLabeledAttributeOfType(typeof(T), label, inherit);
        }

        static public bool TryGetCustomLabeledAttributeOfTypeLabel(this ICustomAttributeProvider item, Type attribute_type, out string label, bool inherit)
        {
            LabeledAttribute labeled_attribute = item.GetCustomAttributeOfSubType<LabeledAttribute>(attribute_type, inherit);

            if (labeled_attribute != null)
            {
                label = labeled_attribute.GetLabel();
                return true;
            }

            label = "";
            return false;
        }
        static public bool TryGetCustomLabeledAttributeOfTypeLabel<T>(this ICustomAttributeProvider item, out string label, bool inherit) where T : LabeledAttribute
        {
            return item.TryGetCustomLabeledAttributeOfTypeLabel(typeof(T), out label, inherit);
        }

        static public string GetCustomLabeledAttributeOfTypeLabel(this ICustomAttributeProvider item, Type attribute_type, bool inherit, string default_value = "")
        {
            string label;

            if (item.TryGetCustomLabeledAttributeOfTypeLabel(attribute_type, out label, inherit))
                return label;

            return default_value;
        }
        static public string GetCustomLabeledAttributeOfTypeLabel<T>(this ICustomAttributeProvider item, bool inherit, string default_value = "") where T : LabeledAttribute
        {
            return item.GetCustomLabeledAttributeOfTypeLabel(typeof(T), inherit, default_value);
        }
	}
	static public class IDynamicCustomAttributeProviderExtensions_LabeledAttribute
    {
		static public bool HasCustomLabeledAttributeOfType(this IDynamicCustomAttributeProvider item, Type attribute_type, string label, bool inherit)
        {
            return item.HasCustomAttributeOfSubType<LabeledAttribute>(attribute_type, inherit, it => it.IsLabeled(label));
        }
        static public bool HasCustomLabeledAttributeOfType<T>(this IDynamicCustomAttributeProvider item, string label, bool inherit) where T : LabeledAttribute
        {
            return item.HasCustomLabeledAttributeOfType(typeof(T), label, inherit);
        }

        static public bool TryGetCustomLabeledAttributeOfTypeLabel(this IDynamicCustomAttributeProvider item, Type attribute_type, out string label, bool inherit)
        {
            LabeledAttribute labeled_attribute = item.GetCustomAttributeOfSubType<LabeledAttribute>(attribute_type, inherit);

            if (labeled_attribute != null)
            {
                label = labeled_attribute.GetLabel();
                return true;
            }

            label = "";
            return false;
        }
        static public bool TryGetCustomLabeledAttributeOfTypeLabel<T>(this IDynamicCustomAttributeProvider item, out string label, bool inherit) where T : LabeledAttribute
        {
            return item.TryGetCustomLabeledAttributeOfTypeLabel(typeof(T), out label, inherit);
        }

        static public string GetCustomLabeledAttributeOfTypeLabel(this IDynamicCustomAttributeProvider item, Type attribute_type, bool inherit, string default_value = "")
        {
            string label;

            if (item.TryGetCustomLabeledAttributeOfTypeLabel(attribute_type, out label, inherit))
                return label;

            return default_value;
        }
        static public string GetCustomLabeledAttributeOfTypeLabel<T>(this IDynamicCustomAttributeProvider item, bool inherit, string default_value = "") where T : LabeledAttribute
        {
            return item.GetCustomLabeledAttributeOfTypeLabel(typeof(T), inherit, default_value);
        }
	}
}