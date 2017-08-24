using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> lnkdlst = new LinkedList<string>();
            lnkdlst.InsertAtEnd("45");
            lnkdlst.InsertAtEnd("55");
            lnkdlst.InsertAtEnd(65.ToString());
            lnkdlst.InsertAtEnd("75");
            lnkdlst.InsertAtEnd("85");
            lnkdlst.InsertAtEnd("95");
            lnkdlst.InsertAtMiddle(60.ToString(), 3);
            lnkdlst.Traverse();
            Console.WriteLine();
            Console.WriteLine(lnkdlst.Count);
            Console.WriteLine(lnkdlst.FindMiddleElement());
            lnkdlst.Reverse();
            lnkdlst.Traverse();
            try
            {
                lnkdlst.Remove(0);
                lnkdlst.Remove(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            lnkdlst.Traverse();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
