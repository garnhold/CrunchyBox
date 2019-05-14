using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public abstract class AIRule_Subsystem<T> : AIRule<T>
    {
        private AIRuleSystem<T> subsystem;

        protected override void UpdateInternal(int channel_mask)
        {
            subsystem.Observe(channel_mask);
        }

        protected override void UpkeepInternal()
        {
            subsystem.Upkeep();
        }

        public AIRule_Subsystem(AIRuleSystem<T> s)
        {
            subsystem = s;
        }
    }
}