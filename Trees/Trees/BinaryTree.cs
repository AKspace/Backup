using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BinaryTree
    {
        public Node root;
        public BinaryTree()
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
                root = newnode;
            else
            {
                Node current = root;
                Node Parent;
                while (true)
                {
                    Parent = current;
                     if (Parent.lchild == null)
                     {
                         Parent.lchild = newnode;
                         return;
                     }
                     else if (Parent.rchild == null)
                     {
                         Parent.rchild = newnode;
                         return;
                     }
                     else
                     {
                         if (Parent.lchild.lchild == null || Parent.lchild.rchild == null)
                         {
                             current = Parent.lchild;
                         }
                         else if (Parent.rchild.lchild != null && Parent.rchild.rchild != null)
                         {
                             current = Parent.lchild;
                         }
                         else
                             current = Parent.rchild;

                     }
                }
            }
        }
        public void Inorder(Node root, List<int> element)
        {
            if (root != null)
            {
                Inorder(root.lchild, element);
                element.Add(root.item);
                Inorder(root.rchild, element);
            }
        }
        public bool checkBST(Node root)
        {
            Node cur = root;
            bool res = true;
            if (cur != null)
            {
                if ( cur.lchild != null && cur.lchild.item > cur.item)
                    res = false;
                else if (cur.rchild != null && cur.rchild.item < cur.item)
                    res = false;
                else
                {
                    res = res & checkBST(cur.lchild) & checkBST(cur.rchild);
                }
            }
            return res;
        }
    }
}
