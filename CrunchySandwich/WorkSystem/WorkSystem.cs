using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

namespace Crunchy.Sandwich
{
    using Dough;
    using Salt;
    
    public class WorkSystem : Subsystem<WorkSystem>
    {
        [SerializeFieldEX]private Duration target_frame_length = Duration.Hertz(60.0f);

        private LazyScheduler scheduler;
        private DecayTimeSet<Tuple<UnityEngine.Object, string>> registered_named_work_ids;

        private void UpdateInternal()
        {
            scheduler.Update(target_frame_length);
            registered_named_work_ids.Decay();
        }

        public WorkSystem()
        {
            scheduler = new LazyScheduler(new BinSchedule(4096, Duration.Seconds(0.050f)));
            registered_named_work_ids = new DecayTimeSet<Tuple<UnityEngine.Object, string>>();
        }

        public override void Update()
        {
            if (Application.isPlaying)
                UpdateInternal();
        }

        public override void UpdateInEditor()
        {
            if (Application.isPlaying == false)
                UpdateInternal();
        }

        public void Schedule(UnityEngine.Object requester, long delay, Process process)
        {
            scheduler.ScheduleIn(delay, delegate() {
                try
                {
                    if (requester.IsNotNull())
                        process();
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
            });
        }

        public void ScheduleNamed(UnityEngine.Object requester, string name, long delay, Process process)
        {
            Tuple<UnityEngine.Object, string> id = new Tuple<UnityEngine.Object, string>(requester, name);

            if(registered_named_work_ids.Add(id, delay, false))
            {
                Schedule(requester, delay, delegate () {
                    process();
                });
            }
        }
    }
}