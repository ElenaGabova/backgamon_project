class Program
{
    static void Main()
    {
        var numbers = ReadData();
        numbers.Reverse();
        var result = string.Join(", ", numbers);
        Console.WriteLine($"\n\nЗначения всех положительных элементов в обратном порядке: {result}");
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
        Console.WriteLine("Введите количество чисел:");
        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            number = 0;
            while (true)
            {
                Console.WriteLine($"Введите значение {i + 1} числа:");
                input = Console.ReadLine();
                if (!int.TryParse(input, out number))
                    Console.WriteLine("Некорректный ввод, значение должно быть числом.");
                else
                {
                    if (number > 0)
                        numbers.Add(number);

                    break;
                }
            }
        }
        return numbers;
    }
}