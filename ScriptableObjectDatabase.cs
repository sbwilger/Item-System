using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Wilgersoft
{
    public class ScriptableObjectDatabase<T> : ScriptableObject where T : class
    {
        [SerializeField] protected List<T> items = new List<T>();

        public List<T> Item
        {
            get
            {
                return items;
            }
        }

        public int Count
        {
            get
            {
                return items.Count;
            }
        }

        public T Get(int index)
        {
            return items.ElementAt(index);
        }

        public int GetIndex(T item)
        {
            return items.IndexOf(item);
        }
    }
}