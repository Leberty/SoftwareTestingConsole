using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    internal class Registration
    {
        public string str;
        Check check = new Check();
        public void WriteString(ref string str)
        {
            str = Console.ReadLine(); //считываем строку с консоли
            while (!check.CheckString(str)) //пока строка пустая или содержит пробелы
            {
                str = Console.ReadLine(); //просим ввести еще раз
            }
        }
    }
}
