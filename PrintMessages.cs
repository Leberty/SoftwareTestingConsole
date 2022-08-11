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

        public PrintMessages(int _x, int _y, string _head) {
            x = _x;
            y = _y;
            head = _head;
        }

        public void PrintHead()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine("=================================================================");
            Console.SetCursorPosition(x, ++y);
            Console.Write("========================= ");
            Console.Write(head);
            Console.WriteLine(" =========================");
            Console.SetCursorPosition(x, ++y);
            Console.WriteLine("=================================================================");
        }
    }
}
