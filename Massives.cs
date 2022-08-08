//Массивы
//Задание одномерного массива
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
string[] peopleNames = new string[5] { "Петр", "Иван", "Анна", "Евгений", "Мария" };

//Размерность массива изначально не определена
string[] strings;
Console.WriteLine("Сколько элементов Вы хотите задать? Введите количество - ");
int count = 0; //Размерность
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
//Увеличим каждый элемент на 3
for (int i = 0; i < ints2.Length; i++)
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

//Многомерный массив
//Двухмерные массивы
int[,] numbers;
int[,] numbers = new int[2, 3];
int[,] numbers = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numbers = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numbers = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
int[,] numbers = { { 0, 1, 2 }, { 3, 4, 5 } };
//Вывод на экран
foreach (int i in numbers)
{
    Console.WriteLine($"{i}");
}
int countRows = numbers.GetUpperBound(0) + 1;//количество строк
int countColumns = numbers.Length / countRows;//количество столбцов
//2 вариант подсчета количества столбцов:
//int countColumns = numbers.GetUpperBound(1) + 1;
//вывод на экран
for (int i = 0; i < countRows; i++)
{
    for (int k = 0; k < countColumns; k++)
    {
        Console.WriteLine($"#[{i};{k}] - {numbers[i,k]}");
    }
    Console.WriteLine();
}

//Пример трехмерного массива
int[,,] numbers3 = new int[2, 3, 4];
Console.WriteLine("");

//Переворот массива в обратном порядке
var rand = new Random(); //Инициализируем рандомный генератор под именем rand
int[] numMas = new int[25]; //Инициализируем массив из 25 элементов
Console.WriteLine("Исходный массив:");
for(int i = 0; i < numMas.Length; i++)
{
    numMas[i] = rand.Next(1,25); //Задаем элементу массива рандомное (случайное) значение
    Console.Write($"{numMas[i]}, ");
}
Console.WriteLine();
int countNumMas = numMas.Length; //длина массива numMas
int average = countNumMas / 2; //средний элемент
int temp = 0; //вспомогательная переменная
for (int i = 0; i < average; i++)
{
    temp = numMas[i];
    numMas[i] = numMas[countNumMas - i - 1];
    numMas[countNumMas - i - 1] = temp;
}
Console.WriteLine("Результирующий массив:");
for (int i = 0; i < numMas.Length; i++)
{
    Console.Write($"{numMas[i]}, ");
}