using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hilos
{
    public class ListWithEvents<T> : List<T>
    {
        private List<T> internalList = new List<T>();

        public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;

        public void Add(T item)
        {
            internalList.Add(item);
            OnItemAdded(item);
        }

        protected virtual void OnItemAdded(T item)
        {
            ItemAdded?.Invoke(this, new ItemAddedEventArgs<T>(item));
        }
    }

    public class ItemAddedEventArgs<T> : EventArgs
    {
        public T Item { get; }
        public ItemAddedEventArgs(T item)
        {
            Item = item;
        }
    }
  

}
