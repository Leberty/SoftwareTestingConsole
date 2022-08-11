namespace RegOnCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            int y = 5;
            string fam = default, name = default, midName = default;
            string head = "Регистрация";
            
            Console.Title = "Регистрация на курсы";
            PrintMessages printMessages = new PrintMessages(); //создаем экземпляр класса PrintMessages
            printMessages.PrintHead(x,y,head);

            Check check = new Check();
            Registration reg = new Registration();

            Console.Write("\nВведите фамилию: ");
            reg.WriteString(ref fam);

            Console.Write("\nВведите имя: ");
            reg.WriteString(ref name);

            Console.Write("\nВведите отчество: ");
            reg.WriteString(ref midName);

            Console.Clear();
            string hello = "Здравствуйте, " + fam + " " + name + " " + midName;
            printMessages.PrintHead(x, y, hello);
            Console.ReadLine();
        }

        
    }
}