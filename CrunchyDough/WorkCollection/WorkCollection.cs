using System;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class WorkCollection<T>
    {
        private int work_index;
        private List<T> work_items;
        
        private Process<T> process;

        public WorkCollection(Process<T> p)
        {
            work_index = 0;
            work_items = new List<T>();

            process = p;
        }

        public void Clear()
        {
            work_items.Clear();
        }

        public void Add(T to_add)
        {
            work_items.Add(to_add);
        }

        public void Remove(T to_remove)
        {
            work_items.Remove(to_remove);
        }

        public void StartWork()
        {
            if (work_index != 0)
                FinishWork();
        }

        public bool WorkSingle()
        {
            if (work_index < work_items.Count)
            {
                process(work_items[work_index]);

                work_index++;
                return true;
            }

            return false;
        }
        public bool WorkCount(int count)
        {
            int i = 1;

            while (WorkSingle() && i < count) ;
            return WorkSingle();
        }
        public bool WorkPercent(float percent)
        {
            return WorkCount((int)(GetNumberItems() * percent) + 1);
        }

        public void FinishWork()
        {
            while (WorkSingle()) ;

            work_index = 0;
        }

        public int GetNumberItems()
        {
            return work_items.Count;
        }
    }
}