using System;
using System.Threading.Tasks;

namespace Crunchy.Dough
{
    static public class DurationExtensions_Wait
    {
        static public async Task WaitFor(this Duration item)
        {
            await Wait.ForDuration(item);
        }
    }
}