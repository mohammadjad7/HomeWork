using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{



    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddAtbeginning(3);
            list.AddAtend(4);
            list.AddAtPosition(5, 1);

            list.PrintList(); // Output: 3 -> 5 -> 4 -> null

            list.DeleteFormbeginning();
            list.DeleteFormend();

            list.PrintList(); // Output: 5 -> null
        }
    }//انشاء صف معمم
    public class Node<A>
    {
        public A Data;
        public Node<A> Next;

        public Node(A data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList<A>
    {
        private Node<A> head;

        public LinkedList()
        {
            head = null;
        }
        //اضافة من بداية
        public void AddAtbeginning(A data)
        {
            Node<A> newNode = new Node<A>(data);
            newNode.Next = head;
            head = newNode;
        }
        //اضافة من نهاية
        public void AddAtend(A data)
        {
            Node<A> newNode = new Node<A>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<A> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        //تحديد موقع
        public void AddAtPosition(A data, int position)
        {
            if (position < 0) throw new ArgumentOutOfRangeException(nameof(position));
            Node<A> newNode = new Node<A>(data);
            if (position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<A> current = head;
                for (int i = 1; i < position && current != null; i++)
                {
                    current = current.Next;
                }
                if (current == null) throw new ArgumentOutOfRangeException(nameof(position));
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }
        //حذف من بداية 
        public void DeleteFormbeginning()
        {
            if (head != null)
            {
                head = head.Next;
            }
        }
        //حذف من نهاية

        public void DeleteFormend()
        {
            if (head == null) return;
            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node<A> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }
        }
        //
        public void PrintList()
        {
            Node<A> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }

}


