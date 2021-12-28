using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    static public class TaskStatusExtensions
    {
        static public bool IsDone(this TaskStatus item)
        {
            switch (item)
            {
                case TaskStatus.Canceled: return true;
                case TaskStatus.Created: return false;
                case TaskStatus.Faulted: return true;
                case TaskStatus.RanToCompletion: return true;
                case TaskStatus.Running: return false;
                case TaskStatus.WaitingForActivation: return false;
                case TaskStatus.WaitingForChildrenToComplete: return false;
                case TaskStatus.WaitingToRun: return false;
            }

            throw new UnaccountedBranchException("item", item);
        }
    }
}