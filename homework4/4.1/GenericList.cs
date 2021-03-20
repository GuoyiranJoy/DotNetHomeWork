using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                tail = head = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for (Node<T> p = head; p != null; p = p.Next)
            {
                action(p.Data);
            }
        }


    }
}
