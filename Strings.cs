// See https://aka.ms/new-console-template for more information
string s = "Hello, world!";
string d = "My dear frends";
Console.WriteLine(s);
//Конкантенация (объединение) строк
Console.WriteLine(s + " " + d);
Console.WriteLine($"{s} {d}");
//Запишем объединение строк в переменную
string sd = s + " " + d;
Console.WriteLine(sd);
//Получим второй символ строки s
char symbol = s[1]; //символ e
Console.WriteLine(symbol);
//Получим длину строки s
int lenS = s.Length; //13

//Спецсимволы
//Символ табуляции
Console.WriteLine($"\t{s}");
//Символ перевода строки
Console.Write($"{d} \r\n");
Console.WriteLine($"{s} \r\n {d}");
//Вывод символа \
Console.WriteLine("\\");
//Вывод двойных кавычек (экранирование)
Console.WriteLine("\" \"");

//Методы
//Примеры пустых строк
string v = "";
string b = null;

//Проверка строку на пустоту
Console.WriteLine("Введите строку");
string strConsole = Console.ReadLine();
if (String.IsNullOrEmpty(strConsole))
{
    Console.WriteLine("Вы ввели пустую строку");
}
else
{
    Console.WriteLine($"Ваша введенная строка: {strConsole}");
}

//Проверка строки на пустоту и на заполненность пробелами
Console.WriteLine("Введите фамилию:");
string strFam = Console.ReadLine();
Console.WriteLine("Введите имя:");
string strName = Console.ReadLine();
while (String.IsNullOrWhiteSpace(strFam) || String.IsNullOrWhiteSpace(strName))
{
    Console.WriteLine("Вы указали пустую фамилию или имя");
    Console.WriteLine("Введите фамилию:");
    strFam = Console.ReadLine();
    Console.WriteLine("Введите имя:");
    strName = Console.ReadLine();
}
Console.WriteLine($"Здравствуйте! {strFam} {strName}");
if (String.IsNullOrWhiteSpace(strFam) || String.IsNullOrWhiteSpace(strName))
{
    Console.WriteLine("Вы указали пустую фамилию или имя");
}
else
{
    Console.WriteLine($"Здравствуйте! {strFam} {strName}");
}

//Сравнение строк
//0 - строки равны, -1 - первая строка меньше второй, 1 - первая больше второй
Console.WriteLine(String.Compare("a", "b")); //-1
Console.WriteLine(String.Compare("a", "a")); //0
Console.WriteLine(String.Compare("b", "a")); //1
Console.WriteLine(String.Compare("ab", "abc")); //-1
Console.WriteLine(String.Compare("Romania", "Russia")); //-1
Console.WriteLine(String.Compare("Rwanda", "Russia")); //1
Console.WriteLine(String.Compare("Rwanda", "Romania")); //1
Console.WriteLine(String.Compare("ab", "AB")); //-1
Console.WriteLine(String.Compare("ab", "AB", true)); //0

//Смена регистра
Console.WriteLine(s.ToUpper()); //HELLO, WORLD!
Console.WriteLine(s.ToLower()); //hello, world!

//Подстрока
if (s.Contains("Hello")) Console.WriteLine("Содержит");
if (s.Contains("hello")) Console.WriteLine("Содержит");
else Console.WriteLine("Не содержит");

//Поиск индекса первого символа подстроки
Console.WriteLine(s.IndexOf("H")); //0
Console.WriteLine(s.IndexOf("World")); //-1
Console.WriteLine(s.IndexOf("world")); //7
Console.WriteLine(s.IndexOf("Butterfly")); //-1

//Вставить подстроку в строку
Console.WriteLine(s.Insert(5," you")); //-1

//Получение подстроки из строки
Console.WriteLine(s.Substring(1, 4)); //ello
Console.WriteLine(s.Substring(7)); //world!

//Замена всех вхождений подстроки
string str = "Hello, Bob! How are you, Bob? Where are you living, Bob?";
Console.WriteLine(str.Replace("Bob","Tom"));

//Обрезка строки
Console.WriteLine(str.Remove(12)); //Hello, Bob!
Console.WriteLine(str.Remove(11, 18)); //Hello, Bob! Where are you living, Bob?
Console.ReadLine();