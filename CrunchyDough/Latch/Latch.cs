using System;

namespace CrunchyDough
{
    public class Latch<T>
    {
        private T latched;
        private bool is_latched;

        private Block block;

        public Latch()
        {
            block = new Block();
        }

        public T Fetch(Operation<T> operation)
        {
            if (is_latched == false)
            {
                block.Execute(delegate() {
                    latched = operation();
                    is_latched = true;
                });
            }

            return latched;
        }
    }
}