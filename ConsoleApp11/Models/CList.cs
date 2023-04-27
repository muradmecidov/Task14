using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Models
{
    public class CList<T>
    {
        private List<T> list;

        public CList() 
        {
            list = new List<T>();
        }
         public void Add(T item)
        {
            list.Add(item);
        }
        public void Clear()
        {
            list.Clear();
        }
        public int Count() 
        { 
            return list.Count; 
        }
        public bool Remove(T item)
        {
            list.Remove(item);
            return true;
        }
        public bool Contains(T item)
        {
            return list.Contains(item);
        }

        


    }
}
