using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    internal class Check
    {
        public string stringForCheck;
        public bool CheckString(string stringForCheck)
        {
            if(String.IsNullOrWhiteSpace(stringForCheck))
            {
                Console.Write("Вы ввели пустую строку. Повторите ввод: ");
                return false;
            }
            return true;
        }
    }
}
