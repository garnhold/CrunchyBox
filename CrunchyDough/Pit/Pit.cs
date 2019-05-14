using System;
using System.Collections;
using System.Collections.Generic;

namespace CrunchyDough
{
    public class Pit<T>
    {
        private Stack<T> stack;
        private Operation<T> create_operation;

        public Pit(Operation<T> c)
        {
            stack = new Stack<T>();
            create_operation = c;
        }

        public T CreateNew()
        {
            return create_operation.Execute();
        }

        public void PushNew()
        {
            Push(CreateNew());
        }

        public void Preallocate(int number)
        {
            for (int i = 0; i < number; i++)
                PushNew();
        }

        public void Push(T item)
        {
            if (item.IsNotNull())
                stack.Push(item);
        }

        public T Pop()
        {
            if (stack.IsNotEmpty())
                return stack.Pop();

            return CreateNew();
        }
    }
}