using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2VY15253022
{
    class Node <T> where T:IComparable
    {
        public T value;
        public Node<T> next;
        public Node<T> prev;
       
        public Node(T value)
        {
            this.value = value;
        }
    }
}
