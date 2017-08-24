using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {
        public Node<T> root;
        public LinkedList()
        {
            root = null;
        }
        public Node<T> GetRoot
        {
            get { return root; }
        }
        public int Count
        {
            get
            {
                int count = 0;
                Node<T> cur = root;
                while (cur != null)
                {
                    count++;
                    cur = cur.link;
                }
                return count;
            }
        }
        public void InsertAtBegin(T item)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = item;
            if (root == null)
                root = newNode;
            else
            {
                newNode.link = root;
                root = newNode; 
            }
        }
        public void InsertAtEnd(T item)
        {
            Node<T> newnode = new Node<T>();
            newnode.data = item;
            if (root == null)
                root = newnode;
            else
            {
                Node<T> cur = root;
                while (cur.link != null)
                    cur = cur.link;
                cur.link = newnode;
            }
        }
        public void InsertAtMiddle(T item, int index)
        {
            Node<T> newNode = new Node<T>();
            newNode.data = item;
            Node<T> cur = root;
            if (index == 0)
            {
                InsertAtBegin(item);
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    cur = cur.link;
                }
                newNode.link = cur.link;
                cur.link = newNode;
            }
        }
        public T FindMiddleElement()
        {
           int i  = 0;
            Node<T> Middle = root;
            while (i < Count/2)
            {
                Middle = Middle.link;
                i++;
            }
            return Middle.data;
        }
        public void Traverse()
        {
            Node<T> cur = root;
            while (cur != null)
            {
                Console.Write(cur.data + "  ");
                cur = cur.link;
            }
            Console.WriteLine();
        }
        public LinkedList<T> Reverse()
        {
            LinkedList<T> reverse = new LinkedList<T>();
            Node<T> cur = root;
            while (cur != null)
            {
                reverse.InsertAtBegin(cur.data);
                cur = cur.link;
            }
            return reverse;
        }
        public void Remove(int index)
        {

            if (index >= Count) throw new ArgumentOutOfRangeException("Index can not be greater than or equal to count");

            if (index == 0)
            {
                root = root.link;
            }
            else
            {
                Node<T> cur = root;
                Node<T> Temp = root;
                for (int i = 0; i < index; i++)
                {
                    Temp = cur;
                    cur = cur.link;
                }
                Temp.link = cur.link;
            }
        }
    }
}
