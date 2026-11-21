using System;
using System.Numerics;
using System.Text;

namespace Testirovanie_1
{
    public static class HelperForPervokyrsnik
    {

        public static void QuickSortIntMass(int[] mas)
        {
            if (mas == null || mas.Length == 0) return;
            QuickSort(mas, 0, mas.Length - 1);
        }

        private static void QuickSort(int[] mas, int left, int right)
        {
            if (left >= right) return;

            int pivot = mas[(left + right) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (mas[i] < pivot) i++;
                while (mas[j] > pivot) j--;

                if (i <= j)
                {
                    int temp = mas[i];
                    mas[i] = mas[j];
                    mas[j] = temp;
                    i++;
                    j--;
                }
            }

            QuickSort(mas, left, j);
            QuickSort(mas, i, right);
        }


        public static bool PalindromStr(string str)
        {
            if (string.IsNullOrEmpty(str))
                return true;

            for (int i = 0; i < str.Length / 2; i++)
            {
                int j = str.Length - 1 - i;
                if (str[i] != str[j])
                    return false;
            }

            return true;
        }


        public static BigInteger Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n не может быть отрицательным");

            BigInteger res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }


        public static BigInteger Fibonacci(int n)
        {
            if (n < 0)
                throw new ArgumentException("Позиция не может быть отрицательной");

            if (n == 0) return 0;
            if (n == 1) return 1;

            BigInteger prev = 0;
            BigInteger curr = 1;

            for (int i = 2; i <= n; i++)
            {
                BigInteger next = prev + curr;
                prev = curr;
                curr = next;
            }

            return curr;
        }


        public static int FindSubstring(string text, string pattern)
        {
            if (text == null) throw new ArgumentNullException(nameof(text));
            if (pattern == null) throw new ArgumentNullException(nameof(pattern));

            return text.IndexOf(pattern);
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;            // 2 и 3
            if (n % 2 == 0 || n % 3 == 0) return false;

            // Используем i <= n / i, чтобы избежать переполнения int при i * i
            for (int i = 5; i <= n / i; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        public static int ReverseInt(int x)
        {
            long result = 0;
            long n = x;

            while (n != 0)
            {
                long digit = n % 10;
                result = result * 10 + digit;
                n /= 10;

                if (result > int.MaxValue || result < int.MinValue)
                    return 0;
            }

            return (int)result;
        }


        public static string ToRoman(int x)
        {
            if (x < 1 || x > 3999)
                throw new ArgumentOutOfRangeException(
                    nameof(x),
                    "Число должно быть в диапазоне от 1 до 3999");

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var sb = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (x >= values[i])
                {
                    sb.Append(symbols[i]);
                    x -= values[i];
                }
            }

            return sb.ToString();
        }
    }
}