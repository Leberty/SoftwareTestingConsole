using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    internal class Courses
    {
        string[] coursesName = { "Тестирование программного обеспечения", "Веб-разработка", "Разработка мобильных приложений", "Графический дизайн", "Программирование игр" };

        public void PrintCoursesList()
        {
            for (int i = 0; i < coursesName.Length; i++)
            {
                Console.WriteLine("{0} - {1}", i, coursesName[i]);
            }
        }

        public string PrintCourseByNumber(int number)
        {
            if (number > coursesName.Length | number < 0)
            {
                Console.WriteLine("Курса с указанным номером не существует");
                return "0";
            }
            return coursesName[number];
        }
    }
}
