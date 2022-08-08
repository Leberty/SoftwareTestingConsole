// See https://aka.ms/new-console-template for more information
//Циклы
//Цикл for (делаем какие-то действие определенное количество раз)
for (int i = 1; i < 10; i++)
{
    //Console.WriteLine(i);
}
//Цикл do.. while (сначала выполняем, потом проверяем)
int j = 10;
do
{
    //Console.WriteLine(j);
    j--;
}
while (j > 0);
//Цикл while (сначала проверяем, потом выполняем
int k = 10;
while (k > 0)
{
    //Console.WriteLine(k);
    k--;
}
//Цикл foreach
foreach (char c in "Hello, world")
{
    //Console.WriteLine(c);
}
//Оператор break
for (int i = 1; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    //Console.WriteLine(i);
}
//Оператор continue
for (int i = 1; i < 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}