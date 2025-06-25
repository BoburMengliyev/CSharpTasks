using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask17
{
    public static class Cache<T>
    {
        public static List<T> cache = new List<T>();
        
        public static void Add(T item)
        {
            if (!cache.Contains(item))
            {
                cache.Add(item);
            }
        }

        public static List<T> Get ()
        {
            return cache;
        }

        public static void Remove(T item)
        {
            if (cache.Contains(item))
            {
                cache.Remove(item);
            }
        }
    }
}
