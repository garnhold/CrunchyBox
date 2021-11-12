using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class AsyncerManager
    {
        private Asyncer root_asyncer;
        private Stack<Asyncer> asyncer_stack;

        static private AsyncerManager INSTANCE;
        static public AsyncerManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new AsyncerManager();

            return INSTANCE;
        }

        private AsyncerManager()
        {
            root_asyncer = new Asyncer();
            asyncer_stack = new Stack<Asyncer>();
        }

        public void Update()
        {
            root_asyncer.Update();
        }

        public void Use(Asyncer asyncer, Process process)
        {
            asyncer_stack.PushPop(asyncer, process);
        }

        public async Task ForUpdate()
        {
            await GetAsyncer().ForUpdate();
        }

        public async Task ForCondition(Predicate predicate)
        {
            while (predicate() == false)
                await ForUpdate();
        }

        public async Task ForDuration(Duration duration)
        {
            Timer timer = new Timer(duration).StartAndGet();

            await ForCondition(() => timer.IsTimeOver());
        }
        public async Task ForMilliseconds(long milliseconds)
        {
            await ForDuration(Duration.Milliseconds(milliseconds));
        }
        public async Task ForSeconds(float seconds)
        {
            await ForDuration(Duration.Seconds(seconds));
        }

        public Asyncer GetAsyncer()
        {
            return asyncer_stack.PeekEX() ?? root_asyncer;
        }
    }
}