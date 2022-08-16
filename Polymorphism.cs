using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegOnCourses
{
    internal class Polymorphism
    {
        private string str = "Строка";
        //перегрузка методов
        //public void DisplayOverload(int a)
        //{
        //    Console.WriteLine("Перезагрузка " + a);
        //}
        public void DisplayOverload(string str)
        {
            Console.WriteLine("Перезагрузка " + str);
        }
        public void DisplayOverload(string str, int b)
        {
            Console.WriteLine("Перезагрузка " + str + " " + b);
        }

        public int DisplayOverload(){
            Console.WriteLine("Перезагрузка");
            return 0;
        }

        //private void DisplayOverload(out int a)
        //{
        //    a = 100;
        //}

        private void DisplayOverload(ref int a)
        {

        }

        public void Display()
        {
            //Передача параметров по ссылке
            //Display2(ref str, ref str);
            //Console.WriteLine(str);

            //Передача массива параметров
            //DisplayOverload(1, "C#", "OOP", "programming");
            //DisplayOverload(2, "C#");
            //DisplayOverload(3);

            string[] strs = { "c#", "OOP", "programming" };
            //strs[0] = strs[0] + "Иванов";
            //strs.SetValue("иванов", 0);
            //Так нельзя
            //DisplayOverload(3, strs, "Method");
            //DisplayOverload(3, strs);
            //DisplayOverload(1, "2", str, "3");
            Console.WriteLine(str);
        }

        public void Display2(ref string str1, ref string str2)
        {
            Console.WriteLine(str);
            str1 = "Строка 1";
            Console.WriteLine(str);
            str2 = "Строка 2";
            Console.WriteLine(str);
            str = "Строка 3";

        }

        //public void DisplayOverload(int a, params string[] parameterArray)
        //{
        //    foreach (string parameter in parameterArray)
        //    {
        //        Console.WriteLine(parameter + " " + a);
        //    }
        //    parameterArray[1] = "600";
        //}

        //Двумерные массивы через params передавать нельзя
        //public void DisplayOverload(int a, params string[,] parameterArray)
        //{

        //}
        public void DisplayOverload(int a, params int[] parameterArray)
        {
            Console.WriteLine("Массив параметров");
        }
        public void DisplayOverload(int a, int b)
        {
            Console.WriteLine("2 целые переменные: " + a + " " + b);
        }
    }
}
