using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            int marks;

            Console.WriteLine("Enter your Marks");
            marks = Convert.ToInt32(Console.ReadLine());

            if (marks >= 80)
            {
                Console.WriteLine("DISTINCTION");
            }
            else if (marks >= 60 && marks < 80)
            {
                Console.WriteLine("CREDIT");
            }
            else if (marks >= 50 && marks < 60)
            {
                Console.WriteLine("PASS");
            }
            else if (marks >= 40 && marks < 50)
            {
                Console.WriteLine("SUPPLEMENTARY");
            }
            else if (marks >= 30 && marks < 40)
            {
                Console.WriteLine("FAIL");
            }


        }
    }
}