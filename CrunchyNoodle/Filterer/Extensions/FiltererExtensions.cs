using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;

namespace CrunchyNoodle
{
    static public class FiltererExtensions
    {
        static public bool Filter<T>(this IEnumerable<Filterer<T>> item, T to_check, out T adjusted)
        {
            bool is_success;
            bool did_change_occur;
            
            ICollection<Filterer<T>> item_multipass = item.PrepareForMultipass();

            do
            {
                is_success = true;
                did_change_occur = false;

                foreach (Filterer<T> sub_item in item_multipass)
                {
                    if (sub_item.Filter(to_check, out adjusted) == false)
                        is_success = false;

                    if (to_check.NotEqualsEX(adjusted))
                    {
                        did_change_occur = true;
                        to_check = adjusted;
                    }
                }
            }
            while (is_success == false && did_change_occur);

            adjusted = to_check;
            return is_success;
        }
    }
}