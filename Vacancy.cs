using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    //Производный класс
    internal class Vacancy: inherit
    {
        public string vacancyName;
        public Vacancy(string part, string subPart, int numberVacancies,string vacancyName)
        {
            //this.part = part;
            //this.subPart = subPart;
            //this.numberVacancies = numberVacancies;
            this.vacancyName = vacancyName;
        }

        public void PrintVacancy()
        {
            Console.WriteLine("Вакансия: " + vacancyName);
        }
    }
}
