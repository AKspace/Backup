using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree bt = new BinaryTree();
            BST the = new BST();
            int[] e = new int[] {2,1, 2, 3, 5, 4, 6, 7};
            foreach (int i in e)
            {
                bt.Insert(i);
                the.Insert(i);
            }
            Console.WriteLine("Inoreder Traversal : ");
            the.Inorder(the.GetRoot);
            Console.WriteLine(" ");
            Console.WriteLine();
           // Node least = the.LCA(the.GetRoot, 8, 25);
            //Console.WriteLine(bt.checkBST(the.GetRoot));
            Console.WriteLine(bt.checkBST(bt.GetRoot));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
