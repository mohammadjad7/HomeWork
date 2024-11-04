using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tr
{


    public class Node<T>
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SimpleLinkedList<T>
    {
        private Node<T> head;

        public SimpleLinkedList()
        {
            head = null;
        }

        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = head;
            head = newNode;
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveFirst()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }

        public void RemoveLast()
        {
            if (head == null) return;
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node<T> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }

        public void PrintList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

    class Program
    {
        static void Main()
        {
            SimpleLinkedList<int> list = new SimpleLinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.PrintList(); // Output: 1 -> 2 -> null

            list.RemoveFirst();
            list.PrintList(); // Output: 2 -> null

            list.AddFirst(3);
            list.RemoveLast();
            list.PrintList(); // Output: 3 -> null
        }
    }
}