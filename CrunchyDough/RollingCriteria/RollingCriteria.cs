using System;

namespace CrunchyDough
{
    public struct RollingCriteria<T>
    {
        private RollingCriteriaTarget target;
        private Operation<double, T> operation;

        public RollingCriteria(RollingCriteriaTarget t, Operation<double, T> o)
        {
            target = t;
            operation = o;
        }

        public bool TrySelect(T i1, T i2, out T output)
        {
            double t1_value = operation.Execute(i1);
            double t2_value = operation.Execute(i2);

            switch (target)
            {
                case RollingCriteriaTarget.Larger:
                    if (t1_value > t2_value)
                    {
                        output = i1;
                        return true;
                    }

                    if (t2_value > t1_value)
                    {
                        output = i2;
                        return true;
                    }
                    break;

                case RollingCriteriaTarget.Smaller:
                    if (t1_value < t2_value)
                    {
                        output = i1;
                        return true;
                    }

                    if (t2_value < t1_value)
                    {
                        output = i2;
                        return true;
                    }
                    break;
            }

            output = default(T);
            return false;
        }
    }
}