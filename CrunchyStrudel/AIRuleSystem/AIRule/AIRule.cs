using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public abstract class AIRule<T>
    {
        private bool did_update_last;

        private AIRuleSystem<T> rule_system;

        protected abstract bool ReserveChannelMaskInternal(out int channel_mask);

        protected virtual void StartInternal() { }
        protected virtual void StopInternal() { }

        protected virtual void UpdateInternal(int channel_mask) { }
        protected virtual void UpkeepInternal() { }

        private void Update(int channel_mask)
        {
            if (did_update_last == false)
                StartInternal();

            UpdateInternal(channel_mask);
            did_update_last = true;
        }

        public AIRule()
        {
            did_update_last = false;

            rule_system = null;
        }

        public int Observe(int mask)
        {
            int channel_mask;

            if (ReserveChannelMaskInternal(out channel_mask))
            {
                if (mask.HasAllBits(channel_mask))
                {
                    Update(channel_mask);
                    return mask.GetBitExclusion(channel_mask);
                }
            }

            Upkeep();
            return mask;
        }

        public void Upkeep()
        {
            if (did_update_last == true)
                StopInternal();

            UpkeepInternal();
            did_update_last = false;
        }

        public void SetRuleSystem(AIRuleSystem<T> r)
        {
            rule_system = r;
        }

        public AIRuleSystem<T> GetRuleSystem()
        {
            return rule_system;
        }

        public T GetEntity()
        {
            return GetRuleSystem().GetEntity();
        }
    }
}