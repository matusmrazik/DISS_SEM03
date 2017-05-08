using System.Collections;
using System.Collections.Generic;

namespace SEM03.Simulation
{
    public class CustomQueue<T> : IReadOnlyCollection<T>
    {
        private readonly LinkedList<T> _list;

        public int Count => _list.Count;

        public CustomQueue()
        {
            _list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            _list.AddLast(item);
        }

        public T Dequeue()
        {
            var item = _list.First.Value;
            _list.RemoveFirst();
            return item;
        }

        public T Peek()
        {
            return _list.First.Value;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public bool Remove(T item)
        {
            return _list.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
