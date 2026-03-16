using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_ADV01
{
    //Q14: Write a SafeList<T> that returns default when the index is invalid.
    public class SafeList<T>
    {
        public List<T> list =  new List<T>();

        public SafeList() { }

         public void Add(T item)
        {
            list.Add(item);
        }
        public void Clear()
        {
            list.Clear();
        }
        public T? Get(int index)
        {
            if (index < 0 || index >= list.Count)
            {
                return default(T);
            }
            return list[index];
        }






        }
}
