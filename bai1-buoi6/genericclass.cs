using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bai1_buoi6.Program;

namespace bai1_buoi6
{
    public class genericclass
    {
        public class GenericList<T>
        { 
               
            public List<T> list;
            public GenericList()
            {
                list = new List<T>();
            }

            public void Add(T item)
            {
              
                list.Add(item);
            }

            public void Remove(T item)
            {
                list.Remove(item);
            }

            public T Get(int index)
            {
                return list[index];
            }

            public int IndexOf(T item)
            {
                return list.IndexOf(item);
            }
        }
    }
}
