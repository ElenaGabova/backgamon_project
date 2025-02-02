class Program
{
    static void Main()
    {
        var numbers = ReadData();
        int top3sum = numbers.OrderByDescending(x => x).Take(3).Sum();
        Console.WriteLine($"\n\nСумма очков 3 лучших команд:{top3sum}");
    }

    /// <summary>
    /// Метод считывает данные с консоли, проверяет корректность ввода
    /// </summary>
    /// <returns></returns>
    private static List<int> ReadData()
    {
        List<int> numbers = new List<int>();
        string input = string.Empty;
        int number = 0;

        for (int i = 0; i < 20; i++)
        {
            number = 0;
            while (true)
            {
                Console.WriteLine($"Введите значение очков для {i + 1} команды:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out number) || number <= 0)
                    Console.WriteLine("Некорректный ввод, значение должно быть числом больше 0.");
                else
                {
                    numbers.Add(number);
                    break;
                }
            }
        }
        return numbers;
    }
}