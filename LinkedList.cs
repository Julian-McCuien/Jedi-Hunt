using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jedi_Hunt
{
    internal class Node
    {
        public Image element;
        public Node next;
        public Node(Image val, Node n)
        {
            element = val;
            next = n;
        }
    }
    class LinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public int Length
        {
            get { return size; }
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public LinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public void AddLast(Image e)
        {
            Node newest = new Node(e, null);
            if (IsEmpty())
                head = newest;
            else
                tail.next = newest;

            tail = newest;
            size++;
        }

        public void Display()
        {
            Node p = head;
            while (p != null)
            {
                Console.Write(p.element + " --->");
                p = p.next;
            }
            Console.WriteLine();
        }

    }
}




