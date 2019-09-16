using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

using CrunchyDough;
using CrunchySalt;

namespace CrunchySandwich
{
    public class WorkSystem : Subsystem<WorkSystem>
    {
        [SerializeFieldEX]private Duration target_frame_length = Duration.Hertz(60.0f);

        private LazyScheduler scheduler;

        public WorkSystem()
        {
            scheduler = new LazyScheduler(new BinSchedule(4096, Duration.Seconds(0.050f)));
        }

        public override void Update()
        {
            if (Application.isPlaying)
                scheduler.Update(target_frame_length);
        }

        public override void UpdateInEditor()
        {
            if (Application.isPlaying == false)
                scheduler.Update(target_frame_length);
        }

        public void Schedule(long delay, Process process)
        {
            scheduler.ScheduleIn(delay, delegate() {
                try
                {
                    process();
                }
                catch (Exception ex)
                {
                    Debug.LogException(ex);
                }
            });
        }
    }
}