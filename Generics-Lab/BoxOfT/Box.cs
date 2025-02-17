﻿namespace BoxOfT
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Box<T>
    {
        private Stack<T> stack;
        public Box()
        {
            this.stack = new Stack<T>();
        }
        public int Count { get { return stack.Count; } }
        public void Add(T element)
        {
            stack.Push(element);
        }

        public T Remove()
        {
            return stack.Pop();
        }
    }
}
