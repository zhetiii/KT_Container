using System.Collections.Generic;

namespace KT_Container
{
    public class Container<T>
    {
        protected List<T> items = new();

        public virtual void Add(T item)
        {
            items.Add(item);
        }

        public int Count => items.Count;
    }
}