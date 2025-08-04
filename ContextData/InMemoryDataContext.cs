using System.Collections.Generic;
using System.Linq;

namespace DataGridWebApi.ContextData
{
    public abstract class InMemoryDataContext<T> where T : class
    {
        List<T> items;
        int lastInsertedKey;

        protected abstract IEnumerable<T> Source { get; }
        protected abstract int GetKey(T item);
        protected abstract void SetKey(T item, int key);
        protected ICollection<T> ItemsInternal => items;
        public ICollection<T> Items => ItemsInternal;

        protected InMemoryDataContext() { 
            items = Source.ToList();
            if (items.Count > 0)
                lastInsertedKey = ItemsInternal.Max(i => GetKey(i));
        }

        public void Add(T item) 
        { 
            lastInsertedKey++;
            SetKey(item, lastInsertedKey);
            items.Add(item);
        }

        public void Remove(T item)
        { 
            items.Remove(item);
        }

        public virtual void SaveChanges() { }

        public IEnumerable<T> GetAll() => Source.ToList();
    }
}
