using System;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Crunchy.Dough
{
    public class AsyerManager
    {
        private Asyer root_asyncer;
        private Stack<Asyer> asyncer_stack;

        static private AsyerManager INSTANCE;
        static public AsyerManager GetInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new AsyerManager();

            return INSTANCE;
        }

        private AsyerManager()
        {
            root_asyncer = new Asyer();
            asyncer_stack = new Stack<Asyer>();
        }

        public void Update()
        {
            root_asyncer.Update();
        }

        public void Use(Asyer asyncer, Process process)
        {
            asyncer_stack.PushPop(asyncer, process);
        }

        public Asyer GetActiveAsyncer()
        {
            return asyncer_stack.PeekEX() ?? root_asyncer;
        }
    }
}