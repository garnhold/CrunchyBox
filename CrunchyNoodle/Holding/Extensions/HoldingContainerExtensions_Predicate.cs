using System;
using System.Reflection;

namespace Crunchy.Noodle
{
    using Dough;
    using Salt;
    
    static public class HoldingContainerExtensions_Predicate
    {
        static public Predicate<T> CanAdd<P, T>(HoldingContainer<P> holding_container) where T : Holdable<P>
        {
            return delegate(T child) {
                FieldInfoEX field_info;

                if (child != null)
                {
                    if (child.TryGetHoldingContainerField<P>(out field_info))
                    {
                        HoldingContainer<P> current_container = field_info.GetValue(child) as HoldingContainer<P>;

                        if (current_container != holding_container)
                        {
                            if (current_container == null || current_container.Remove(child))
                            {
                                field_info.SetValue(child, holding_container);
                                return true;
                            }
                        }
                    }
                }

                return false;
            };
        }

        static public Predicate<T> CanRemove<P, T>(HoldingContainer<P> holding_container) where T : Holdable<P>
        {
            return delegate(T child) {
                FieldInfoEX field_info;

                if (child != null)
                {
                    if (child.TryGetHoldingContainerField<P>(out field_info))
                    {
                        HoldingContainer<P> current_container = field_info.GetValue(child) as HoldingContainer<P>;

                        if (current_container == holding_container)
                        {
                            field_info.SetValue(child, null);
                            return true;
                        }
                    }
                }

                return false;
            };
        }
    }
}