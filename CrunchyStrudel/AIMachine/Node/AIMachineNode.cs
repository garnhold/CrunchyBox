using System;
using System.Collections;
using System.Collections.Generic;

using CrunchyDough;
using CrunchyNoodle;
using CrunchyBun;

namespace CrunchyStrudel
{
    public class AIMachineNode
    {
        private string name;

        private AIMachineBehaviour behaviour;
        private List<AIMachineTransition> transitions;

        public AIMachineNode(string n)
        {
            name = n;

            transitions = new List<AIMachineTransition>();
        }

        public void Initialize(AIMachineBehaviour b, IEnumerable<AIMachineTransition> t)
        {
            behaviour = b;
            transitions.Set(t);
        }
        public void Initialize(AIMachineBehaviour b, params AIMachineTransition[] t)
        {
            Initialize(b, (IEnumerable<AIMachineTransition>)t);
        }

        public void Resume()
        {
            behaviour.Resume();

            transitions.Process(t => t.Resume());
        }

        public void Suspend()
        {
            behaviour.Suspend();

            transitions.Process(t => t.Suspend());
        }

        public AIMachineNode Update()
        {
            behaviour.Update();

            return transitions
                .Convert(t => t.Update())
                .GetFirstNonNull() ?? this;
        }

        public string GetName()
        {
            return name;
        }
    }
}