//Массивы
int[] ints = new int[4];
//Задание массива с клавиатуры при помощи цикла for
for (int i = 0; i < ints.Length; i++)
{
    Console.Write($"Введите {i}-ый элемент массива: ");
    ints[i] = Convert.ToInt32(Console.ReadLine());
}
//Вывод на экран массива при помощи цикла foreach
Console.Write("{");
foreach (int i in ints)
{
    Console.Write($"{i}; ");
}
Console.Write("}");
Console.WriteLine();
//Вывод массива на экран при помощи цикла for
Console.WriteLine("======Вывод массива на экран======");
for (int i = 0; i < ints.Length; i++)
{
    Console.WriteLine($"№{i} - {ints[i]}");
}
int[] ints2 = new int[3] { 1, 2, 3 };
string[] peopleNames = new string[5] {"Петр", "Иван", "Анна", "Евгений", "Мария"};

//Размерность массива изначально не определена
string[] strings;
Console.WriteLine("Сколько элементов Вы хотите задать? Введите количество - ");
int count = 0;
count = Convert.ToInt32(Console.ReadLine());
strings = new string[count];
for (int i = 0; i < strings.Length; i++)
{
    Console.Write($"Введите {i}-ый элемент массива: ");
    strings[i] = Console.ReadLine();
}

//Изменим 2 элемент в массиве ints2
ints2[1] = 5;
//Получим 3 элемент в массиве ints2
var n = ints2[2];
for ( int i = 0;  i < ints2.Length; i++)
{
    ints2[i] = ints2[i] + 3;
    Console.WriteLine(ints2[i]);
}
//Вывод цикла на экран при помощи цикла while
int j = 0;
while (j < ints2.Length)
{
    Console.WriteLine(ints2[j]);
    j++;
}
Console.WriteLine("");