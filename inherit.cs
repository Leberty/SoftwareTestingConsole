using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    //Базовый класс
    internal class inherit
    {
        const string URL = "https://r21.spb.ru/";
        private string part, subPart; //раздел, подраздел, private - недоступен из остального кода
        protected int numberVacancies; //количество вакансий, protected - доступен для производных классов, но недоступен для остального кода

        public void printInfo()
        {
            Console.Write("Сайт: {0} \n Раздел: {1} \n Подраздел: {2} \n Количество вакансий: {3}\n", URL, part, subPart, numberVacancies);
        }
    }
}
