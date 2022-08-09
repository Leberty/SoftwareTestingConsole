// See https://aka.ms/new-console-template for more information

string language = "sp";

switch (language)
{
    case "en":
        //WriteHelloEn();
        break;
    case "ru":
        //WriteHelloRu();
        break;
    case "sp":
        //WriteHelloSp();
        break;
}

//Метод, выводит на экран Hello, world! (процедура)
void WriteHelloEn()
{
    Console.WriteLine("Hello, World!");
}

void WriteHelloRu()
{
    Console.WriteLine("Привет, мир!");
}

void WriteHelloSp()
{
    Console.WriteLine("¡Hola Mundo!");
}

//Метод с параметром
void WriteMessage(string message)
{
    Console.WriteLine(message);
}

//Передаем значения для параметра
WriteMessage("I love C#");
WriteMessage("Sunny weather");

Console.WriteLine("==========================================================");
Console.WriteLine("==================Консольный калькулятор==================");
Console.WriteLine("==========================================================");
double number1 = 0;
double number2 = 0;
Console.WriteLine("Введите первое число:");
while(!Double.TryParse(Console.ReadLine(), out number1))
{
    Console.WriteLine("Вы ввели не число. Попробуйте ввод еще раз:");
}
Console.WriteLine("Введите второе число:");
while (!Double.TryParse(Console.ReadLine(), out number2))
{
    Console.WriteLine("Вы ввели не число");
}

Console.WriteLine("Введите знак операции:");
char operation = '+';
operation = Convert.ToChar(Console.ReadLine());
switch (operation)
{
    case '+':
        Sum(number1,number2);
        break;
    case '-':
        Minus(number1, number2);
        break;
    case '/':
        Divide(number1, number2);
        break;
    case '*':
        Multiply(number1, number2);
        break;
}
void Sum(double number1, double number2)
{
    double result = number1 + number2;
    Console.WriteLine($"{number1} + {number2} = {result}");
}

void Minus(double num1, double num2)
{
    double result = num1 - num2;
    Console.WriteLine($"{num1} - {num2} = {result}");
}

void Multiply(double num1, double num2)
{
    double result = num1 * num2;
    Console.WriteLine($"{num1} * {num2} = {result}");
}

void Divide(double num1, double num2)
{
    if (num2 == 0)
    {
        Console.WriteLine($"Деление на ноль");
    }
    else
    {
        double result = (double)num1 / num2;
        Console.WriteLine($"{num1} / {num2} = {result}");
    }
}