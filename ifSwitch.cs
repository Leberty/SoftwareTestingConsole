char symbol;
int result = 0;
Console.WriteLine("Введите знак арифметического действия:");
Console.WriteLine("\"*\" - операция умножения;");
Console.WriteLine("\"-\" - операция вычитания;");
Console.Write("Знак операции (ожидание ввода с клавиатуры): ");
symbol = Convert.ToChar(Console.ReadLine());

//Выполнение операции при помощи ветвления
if (symbol == '*')
    result = 5 * 6;
else if (symbol == '-')
    {
        result = 5 - 6;
    }
    else Console.WriteLine("Запрашиваемая Вами операция не может быть выполнена.");

//Другой вариант ветвления
if (symbol == '*')
    result = 5 * 6;
if (symbol == '-')
{
    result = 5 - 6;
}
if (symbol != '*' & symbol != '-')
    Console.WriteLine("Запрашиваемая Вами операция не может быть выполнена.");

//Выполнение операции при помощи переключателя
switch (symbol)
{
    case '-':
        Console.WriteLine($"5 - 6 = {5 - 6}");
        break;
    case '*':
        Console.WriteLine($"5 * 6 = {5 * 6}");
        break;
    default:
        Console.WriteLine("Указанная Вами операция не может быть выполнена");
        break;
}