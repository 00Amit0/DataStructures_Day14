using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    public class SortedNode<T>
    {
        public T data;
        public SortedNode<T> next;

        public SortedNode(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
