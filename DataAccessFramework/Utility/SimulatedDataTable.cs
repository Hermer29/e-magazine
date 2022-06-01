using System;
using System.Collections;
using System.Collections.Generic;

namespace DataAccessFramework.Utility
{
    internal class SimulatedDataTable<TValue> : IEnumerable<KeyValuePair<int, TValue>>
    {
        private Dictionary<int, TValue> _dictionary = new();
        private int _lastAddItemId = 0;

        internal TValue this[int id]
        {
            get => _dictionary[id];
            set => _dictionary[id] = value;
        }

        public IEnumerator<KeyValuePair<int, TValue>> GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<int, TValue>>)_dictionary).GetEnumerator();
        }

        internal void Add(TValue value)
        {
            _dictionary.Add(_lastAddItemId++, value);
        }

        internal bool ContainsId(int id) => _dictionary.ContainsKey(id);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_dictionary).GetEnumerator();
        }

        internal void Remove(int id) => _dictionary.Remove(id);
    }
}
