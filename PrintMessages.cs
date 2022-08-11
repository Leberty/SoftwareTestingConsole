using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    internal class PrintMessages
    {
        public int x;
        public int y;
        public string head;
        public void PrintHead(int x, int y, string head)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("=================================================================");
            Console.Write("========================= ");
            Console.Write(head);
            Console.WriteLine(" =========================");
            Console.WriteLine("=================================================================");
        }
    }
}
