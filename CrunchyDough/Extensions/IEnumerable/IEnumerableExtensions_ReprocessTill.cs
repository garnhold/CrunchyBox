using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class IEnumerableExtensions_ReprocessTill
    {
        static public bool ReprocessTillComplete<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            if (item != null)
            {
                int total_number = 0;
                int previous_total_number = 0;

                int number_failed = 0;
                int previous_number_failed = 0;

                do
                {
                    previous_total_number = total_number;
                    previous_number_failed = number_failed;

                    number_failed = item.Count(i => process(i) == false, out total_number);
                } while (number_failed > 0 || total_number != previous_total_number);

                if (number_failed <= 0)
                    return true;
            }

            return false;
        }

        static public bool ReprocessTillCompleteOrStagnated<T>(this IEnumerable<T> item, TryProcess<T> process)
        {
            if (item != null)
            {
                int total_number = 0;
                int previous_total_number = 0;

                int number_failed = 0;
                int previous_number_failed = 0;
                
                do
                {
                    previous_total_number = total_number;
                    previous_number_failed = number_failed;

                    number_failed = item.Count(i => process(i) == false, out total_number);
                    if (total_number == previous_total_number && number_failed == previous_number_failed)
                        break;

                }while(number_failed > 0 || total_number != previous_total_number);

                if (number_failed <= 0)
                    return true;
            }

            return false;
        }
    }
}