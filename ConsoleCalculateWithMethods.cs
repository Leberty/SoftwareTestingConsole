// See https://aka.ms/new-console-template for more information
int Factorial(int n)
{
    if (n == 1) return 1;
    return n * Factorial(n - 1);
}

int Factorial4 = Factorial(4);
Console.WriteLine($"Факториал числа 4 = {Factorial4}");
Console.ReadLine();