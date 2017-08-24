using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seatallocation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string [6, 6];
            int j = 0;
            Courses[] branch = new Courses[4];
            branch[0] = new Courses();
            branch[1] = new Courses();
            branch[2] = new Courses();
            branch[3] = new Courses();
            branch[0].Branch = "ME";
            branch[1].Branch = "CS";
            branch[2].Branch = "EC";
            branch[3].Branch = "EE";
            branch[0].Rollno = 0;
            branch[1].Rollno = 0;
            branch[2].Rollno = 0; 
            branch[3].Rollno = 0;
            int k =0;
            while (j < 6)
            {
                int i = 0;
                while (i < 6)
                {
                    if(k > 3)
                        k = 0;
                    string temp = branch[k].Branch + branch[k].Rollno.ToString();
                    array[i, j] = temp;
                    branch[k].Rollno++;
                    k++;
                    i++; 
                }
                j++;
            }
            for (int i = 0; i < 6; i++)
            {
                for (int n = 0; n < 6; n++)
                {
                    Console.Write(array[i, n] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        
        }
    }
    class Courses
    {
        public int Rollno
        {
            get;
            set;
        }
        public string Branch
        {
            get;
            set;
        }
    }

}
