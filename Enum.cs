//Тип перечисление
//Перечисление ВременаГода
enum YearSeasons
{
    Summer, //Лето
    Autumn, //Осень
    Winter, //Зима
    Spring //Весна
}

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YearSeasons summer = YearSeasons.Summer;
            if (summer == YearSeasons.Summer)
            {
                Console.WriteLine("Сейчас лето");
            }
            else
            {
                Console.WriteLine("Лето еще не наступило");
            }
            PrintMessage(YearSeasons.Summer);
            PrintMessage(YearSeasons.Winter);
        }

        static void PrintMessage(YearSeasons currentSeasons)
        {
            switch(currentSeasons) {
                case YearSeasons.Summer:
                    Console.WriteLine("Сейчас лето");
                    break;
                case YearSeasons.Winter:
                    Console.WriteLine("Скоро Новый Год");
                    break;
                case YearSeasons.Autumn:
                    Console.WriteLine("Скоро в школу");
                    break;
                case YearSeasons.Spring:
                    Console.WriteLine("Скоро в отпуск");
                    break;
            }
        }
    }
}