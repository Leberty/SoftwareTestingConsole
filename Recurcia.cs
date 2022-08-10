// See https://aka.ms/new-console-template for more information
//Рекурсивный метод вычисления факториала
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}

int Factorial3 = Factorial(3);
Console.WriteLine($"Факториал числа 3 = {Factorial3}");

Console.ReadLine();