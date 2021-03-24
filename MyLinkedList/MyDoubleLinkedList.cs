using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    class MyDoubleLinkedNode<T> : IDoubleLinkedNode<T> where T : IComparable
    {
        public T Value { get; set; }
        public IDoubleLinkedNode<T> Next { get; set; }
        public IDoubleLinkedNode<T> Prev { get; set; }
    }
    public class MyDoubleLinkedList<T> : IDoubleLinkedList<T> where T : IComparable
    {
        public IDoubleLinkedNode<T> First { get; set; }
        public IDoubleLinkedNode<T> Last { get; set; }

        public int Count { get; private set; } = 0;

        public void AddFirst(T value)
        {
            MyDoubleLinkedNode<T> newNode = new MyDoubleLinkedNode<T>()
            {
                Value = value,
                Next = First
            };

            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
                Count++;
                return;
            }

            First.Prev = newNode;
            First = newNode;
            Count++;
        }

        public void AddLast(T value)
        {
            MyDoubleLinkedNode<T> newNode = new MyDoubleLinkedNode<T>()
            {
                Value = value,
                Prev = Last
            };

            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
                Count++;
                return;
            }

            Last.Next = newNode;
            Last = newNode;
            Count++;
        }

        public void Reverse()
        {
            IDoubleLinkedNode<T> currentNode = First;
            while (currentNode != null)
            {
                IDoubleLinkedNode<T> tempNode = currentNode.Next;
                currentNode.Next = currentNode.Prev;
                currentNode.Prev = tempNode;
                currentNode = tempNode;
            }

            currentNode = Last;
            Last = First;
            First = currentNode;
        }

        public bool Contains(T value)
        {
            IDoubleLinkedNode<T> currentNode = First;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) == 0)
                {
                    return true;
                }

                currentNode = currentNode.Next;
            }

            return false;
        }

        public T this[int i]
        {
            get
            {
                if (i > Count - 1 || i < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                int counter = 0;
                IDoubleLinkedNode<T> currentNode = First;
                while (counter != i)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }

                return currentNode.Value;
            }
        }
    }
}
