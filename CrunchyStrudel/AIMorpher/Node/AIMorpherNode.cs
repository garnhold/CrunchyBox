using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Strudel
{
    using Dough;
    using Noodle;
    using Bun;
    
    public abstract class AIMorpherNode
    {
        private float current_interest;
        private List<AIMorpherNode> nodes;

        protected abstract float UpkeepInternal();

        protected virtual void ResumeInternal() { }
        protected virtual void SuspendInternal() { }
        protected virtual void UpdateInternal(float interest) { }

        private double Upkeep(float step)
        {
            current_interest += (UpkeepInternal() - 0.5f) * step;

            current_interest = current_interest.BindPercent();
            return current_interest;
        }

        public AIMorpherNode()
        {
            nodes = new List<AIMorpherNode>();
        }

        public void Initialize(IEnumerable<AIMorpherNode> n)
        {
            nodes.Set(n);
        }

        public void Resume()
        {
            ResumeInternal();
        }

        public void Suspend()
        {
            SuspendInternal();
        }

        public AIMorpherNode Update(float step)
        {
            double other_interest;
            AIMorpherNode other_node = nodes.FindHighestRated(n => n.Upkeep(step), out other_interest);

            if (other_interest >= Upkeep(step) * 2.0f)
                return other_node;

            UpdateInternal(current_interest);
            return this;
        }

        public double GetCurrentInterest()
        {
            return current_interest;
        }
    }
}