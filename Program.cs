namespace RegOnCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 16;
            int y1 = 5;
            string fam = default, name = default, midName = default;
            string head = "Регистрация";
            int number = 0;
            string courseName;

            Console.Title = "Регистрация на курсы";
            PrintMessages printMessages1 = new PrintMessages(x1,y1,head); //создаем экземпляр класса PrintMessages
            printMessages1.PrintHead();

            Check check = new Check();
            Registration reg = new Registration();

            Console.Write("\nВведите фамилию: ");
            reg.WriteString(ref fam);

            Console.Write("\nВведите имя: ");
            reg.WriteString(ref name);

            Console.Write("\nВведите отчество: ");
            reg.WriteString(ref midName);

            Console.Clear();

            int x2 = Console.BufferWidth / 4;
            int y2 = Console.WindowHeight / 3;
            string hello = "Здравствуйте, " + fam + " " + name + " " + midName;
            PrintMessages printMessages2 = new PrintMessages(x2,y2,hello);
            printMessages2.PrintHead();

            Console.Clear();

            PrintMessages printMessages3 = new PrintMessages(x1, y1, "Выбор курса");
            printMessages3.PrintHead();
            Console.WriteLine("Список курсов:");
            Console.WriteLine("номер - название курса");
            Courses courses = new Courses();
            courses.PrintCoursesList();
            Console.Write("Для записи на курс введите цифру, соответствующую номеру курса в списке: ");
            number = int.Parse(Console.ReadLine());

            while(courses.PrintCourseByNumber(number) == "0")
            {
                Console.WriteLine("\nВведите номер курса еще раз: ");
                number = int.Parse(Console.ReadLine());
            }
            courseName = courses.PrintCourseByNumber(number);

            Console.Clear();

            PrintMessages printMessages4 = new PrintMessages(x1, y1, $"{fam} {name} {midName}, Вы успешно записались на курс \"{courseName}\"");
            printMessages4.PrintHead();

            Console.ReadLine();
        } 
    }
}