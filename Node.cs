using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresDemo
{
    public class Node
    {
        public int data;         //holds elements
        public Node next;        //holds pointer position of next element
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
        }
    }
}
