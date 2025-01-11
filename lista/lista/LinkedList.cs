using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    internal class LinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void AddFirst(T value)
        {
            var newNode = new Node<T>(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
        }

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (head == null) return;

            head = head.next;
            if (head == null)
            {
                tail = null;
            }
            else
            {
                head.prev = null;
            }
        }

        public void RemoveLast()
        {
            if (tail == null) return;

            tail = tail.prev;
            if (tail == null)
            {
                head = null;
            }
            else
            {
                tail.next = null;
            }
        }

        public T[] ToArray()
        {
            var list = new List<T>();
            var current = head;
            while (current != null)
            {
                list.Add(current.value);
                current = current.next;
            }
            return list.ToArray();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var current = head;
            while (current != null)
            {
                sb.Append(current.value + " ");
                current = current.next;
            }
            return sb.ToString().Trim();
        }
    }
}
