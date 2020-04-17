using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Bread
{
    using Dough;
    
    public class MenuRepeater<T>
    {
        private T held_value;
        private T zero_value;

        private Timer delay_timer;
        private Timer repeat_timer;
        private ConductedValue<T> repeater;

        private IEnumerable<ConductorOrder> Orders()
        {
            yield return repeater.Order_FlickerValue(held_value, zero_value);
            yield return repeater.Order_WaitFor(delay_timer);

            while (true)
            {
                yield return repeater.Order_FlickerValue(held_value, zero_value);
                yield return repeater.Order_WaitFor(repeat_timer);
            }
        }

        public MenuRepeater(T z, Duration d, Duration r, TimeSource t)
        {
            held_value = z;
            zero_value = z;

            delay_timer = new Timer(d, t);
            repeat_timer = new Timer(r, t);
            repeater = new ConductedValue<T>(zero_value).StartAndGet();
        }

        public MenuRepeater(Duration d, Duration r, TimeSource t) : this(default(T), d, r, t) { }
        public MenuRepeater(Duration d, Duration r) : this(default(T), d, r, TimeSource_System.INSTANCE) { }
        public MenuRepeater() : this(Duration.Seconds(1.1f), Duration.Seconds(0.1f)) { }

        public void UpdateValue(T value)
        {
            if (value.NotEqualsEX(held_value))
            {
                held_value = value;

                repeater.SetOrder(Orders);
            }

            repeater.UpdateFulfill();
        }

        public void SetDurations(Duration delay, Duration repeat)
        {
            SetDelayDuration(delay);
            SetRepeatDuration(repeat);
        }
        public void SetDelayDuration(Duration duration)
        {
            delay_timer.SetDuration(duration);
        }
        public void SetRepeatDuration(Duration duration)
        {
            repeat_timer.SetDuration(duration);
        }

        public T GetMenuValue()
        {
            return repeater.GetValue();
        }
    }
}