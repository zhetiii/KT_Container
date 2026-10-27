using System;

namespace KT_Container
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== StringContainer ===");
            StringContainer stringContainer = new StringContainer();

            Console.WriteLine("Введите две строки для StringContainer:");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"Строка #{i}: ");
                string input = Console.ReadLine();
                stringContainer.Add(input);
            }

            Console.WriteLine("\nРезультат PrintAllUpper():");
            stringContainer.PrintAllUpper();

            Console.WriteLine();

            Console.WriteLine("=== CountingContainer<int> ===");
            CountingContainer<int> intContainer = new CountingContainer<int>();

            Console.WriteLine("Введите 3 целых числа для добавления в intContainer:");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Число #{i}: ");
                int number = int.Parse(Console.ReadLine());
                intContainer.Add(number);
            }

            Console.WriteLine($"Count == {intContainer.Count}, TotalAdded == {intContainer.TotalAdded}");

            Console.WriteLine();

            Console.WriteLine("=== CountingContainer<string> ===");
            CountingContainer<string> countingStrContainer = new CountingContainer<string>();

            Console.WriteLine("Введите 2 строки для CountingContainer<string>:");
            for (int i = 1; i <= 2; i++)
            {
                Console.Write($"Строка #{i}: ");
                string text = Console.ReadLine();
                countingStrContainer.Add(text);
            }

            Console.WriteLine($"Count == {countingStrContainer.Count}, TotalAdded == {countingStrContainer.TotalAdded} (независимо от предыдущего экземпляра)");
        }
    }
}