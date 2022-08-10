// See https://aka.ms/new-console-template for more information
//Console.WriteLine("==========================================================");
//Console.WriteLine("==================Консольный калькулятор==================");
//Console.WriteLine("==========================================================");
//double number1 = CheckWrite();
//double number2 = CheckWrite();
double result = default;


double CheckWrite()
{
    double number;
    Console.WriteLine("Введите число:");
    while (!Double.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Вы ввели не число. Попробуйте ввод еще раз:");
    }
    Console.WriteLine("Ожидание...");
    return number;
}

//Console.WriteLine("Введите знак операции:");
//char operation = '+';
//operation = Convert.ToChar(Console.ReadLine());
//switch (operation)
//{
//    case '+':
//        result = Sum(number1, number2);
//        break;
//    case '-':
//        result = Minus(number1, number2);
//        break;
//    case '/':
//        result = Divide(number1, number2);
//        break;
//    case '*':
//        result = Multiply(number1, number2);
//        break;
//}

//Console.WriteLine($"Результат: {result}");

double Sum(double number1, double number2)
{
    return number1 + number2;
}

double Minus(double number1, double number2)
{
    return number1 - number2;
}

double Divide(double number1, double number2)
{
    return number1 / number2;
}

double Multiply(double number1, double number2)
{
    return number1 * number2;
}

//Передача параметров
//По ссылке
void IncrementLink(ref int num)
{
    num++;
    Console.WriteLine($"Число в методе IncrementLink: {num}");
}
//По ссылке, но нельзя менять исходную переменную
void IncrementLinkNoChange(in int num)
{
    Console.WriteLine($"Число в методе IncrementLink: {num}");
}

//По значению
void Increment(int num)
{
    num++;
    Console.WriteLine($"Число в методе Increment: {num}");
}

//int number = 8;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(number);
//Console.WriteLine($"Число после метода Increment: {number} \n\n");

//Console.WriteLine($"Число до метода IncrementLink: {number}");
//IncrementLink(ref number);
//Console.WriteLine($"Число после метода IncrementLink: {number}");

//Метод с выходным параметром
void SumOut(double number1, double number2, out double result)
{
    result = number1 + number2;
}

double resultSum = default;
SumOut(6,10.5,out resultSum);
Console.WriteLine();