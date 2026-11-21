using System;
using Testirovanie_1;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Быстрая сортировка (QuickSort)
            Console.WriteLine("1. QuickSortIntMass (Быстрая сортировка):");
            int[] mas = { 3, 1, 4, 2, 5, 0, -1, 2 };
            Console.WriteLine($"   До сортировки: [{string.Join(", ", mas)}]");
            HelperForPervokyrsnik.QuickSortIntMass(mas);
            Console.WriteLine($"   После:         [{string.Join(", ", mas)}]\n");

            // 2. Проверка на палиндром (PalindromStr)
            Console.WriteLine("2. PalindromStr (Строка-палиндром):");
            string[] stringsToTest = { "level", "hello", "abba", "a" };
            foreach (var s in stringsToTest)
            {
                bool isPal = HelperForPervokyrsnik.PalindromStr(s);
                Console.WriteLine($"   \"{s}\" -> {isPal}");
            }
            Console.WriteLine();

            // 3. Факториал (Factorial)
            Console.WriteLine("3. Factorial (Факториал):");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"   {i}! = {HelperForPervokyrsnik.Factorial(i)}");
            }
            Console.WriteLine();

            // 4. Числа Фибоначчи (Fibonacci)
            Console.WriteLine("4. Fibonacci (Числа Фибоначчи):");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{HelperForPervokyrsnik.Fibonacci(i)} ");
            }
            Console.WriteLine("\n");

            // 5. Поиск подстроки (FindSubstring)
            Console.WriteLine("5. FindSubstring (Поиск подстроки):");
            string text = "Привет, мир!";
            Console.WriteLine($"   Текст: \"{text}\"");
            Console.WriteLine($"   Поиск \"мир\" -> Индекс: {HelperForPervokyrsnik.FindSubstring(text, "мир")}");
            Console.WriteLine($"   Поиск \"кот\" -> Индекс: {HelperForPervokyrsnik.FindSubstring(text, "кот")}\n");

            // 6. Проверка на простое число (IsPrime)
            Console.WriteLine("6. IsPrime (Простое число):");
            int[] numbers = { 1, 2, 3, 4, 17, 25, 97 };
            foreach (var n in numbers)
            {
                Console.WriteLine($"   Число {n} -> {HelperForPervokyrsnik.IsPrime(n)}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}