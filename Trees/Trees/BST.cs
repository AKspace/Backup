using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BST
    {
        public Node root;
        public BST()
        {
            root = null;
        }
        public Node GetRoot
        {
            get { return root; }
        }
        public void Insert(int item)
        {
            Node newnode = new Node();
            newnode.item = item;
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current = root;
                Node Parent;
                while (true)
                {
                    Parent = current;
                    if (item < current.item)
                    {
                        current = current.lchild;
                        if (current == null)
                        {
                            Parent.lchild = newnode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rchild;
                        if (current == null)
                        {
                            Parent.rchild = newnode;
                            return;
                        }
                    }
                }
            }
        }
        public void Inorder(Node root)
        {
            if (root != null)
            {
                Inorder(root.lchild);
                Console.Write(" {0}, ", root.item);
                Inorder(root.rchild);
            }
        }
        public void Preorder(Node root)
        {
            if (root != null)
            {
                Console.Write(" {0}, ", root.item);
                Preorder(root.lchild);
                Preorder(root.rchild);
            }
        }
        public void Postorder(Node root)
        {
            if (root != null)
            {
                Postorder(root.lchild);
                Postorder(root.rchild);
                Console.Write(" {0}, ", root.item);
            }
        }
        public string Find(int item)
        {
            Node cur = root;
            while (cur !=null)
            {
                if (cur.item == item)
                {
                    return " Element Exists in Tree";
                }
                else if (cur.item < item)
                    cur = cur.rchild;
                else
                    cur = cur.lchild;
            }
            return "Element does not Exist";
        }
        public Node LCA(Node root, int a, int b)
        {
            if (root.item > a && root.item > b)
                return LCA(root.lchild, a, b);
            else if (root.item < a && root.item < b)
                return LCA(root.rchild, a, b);
            else 
                return root;
        }
    }
}
