using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class Mystack<T>
    {
        private const int MaxSize = 10; // Stack max boyutu 
        public Stack<T> stack = new Stack<T>();
        public void Push(T item)
        {
            if (stack.Count > MaxSize)
            {
                throw new InvalidOperationException("Stack kapasiteine ulaşıldı");
            }
            stack.Push(item); // Stack e eleman eklendi
        }
        public T Pop() => stack.Pop(); // Stackten eleman çıkarıldı

        public T Peek() => stack.Peek(); // Stackteki en üstteki eleman döndürüldü
        public int Count => stack.Count; // stack boyutu döndürüldü.


    }
}
