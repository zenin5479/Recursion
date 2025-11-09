using System;

// Рекурсия

namespace Recursion
{
   internal class Program
   {
      static void Main()
      {

         Console.Title = "Рекурсия";
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Задача Коллаца");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write("Введите начальное число: ");
         if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
         {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Последовательность Коллатца:");
            PrintSequence(n);
            Console.WriteLine("\nДлина последовательности: {0}", GetSequenceLength(n));
            Console.WriteLine("Максимальный элемент: {0}", GetMaxElement(n));
         }
         else
         {
            Console.WriteLine("Ошибка: введите положительное целое число");
         }

         // Восстановление исходного цвета консоли
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("Восстановлены исходные цвета консоли");
         Console.ResetColor();

         Console.ReadKey();
      }

      // Рекурсивный вывод последовательности
      static void PrintSequence(int n)
      {
         Console.Write("{0} ", n);
         if (n == 1)
         {
            return;
         }

         if (n % 2 == 0)
         {
            PrintSequence(n / 2);
         }
         else
         {
            PrintSequence(3 * n + 1);
         }
      }

      // Рекурсивный расчет длины последовательности
      static int GetSequenceLength(int n)
      {
         if (n == 1)
         {
            return 1;
         }

         if (n % 2 == 0)
         {
            return 1 + GetSequenceLength(n / 2);
         }

         return 1 + GetSequenceLength(3 * n + 1);
      }

      // Рекурсивный поиск максимального элемента
      static int GetMaxElement(int n)
      {
         return GetMaxElement(n, n);
      }

      static int GetMaxElement(int n, int currentMax)
      {
         if (n == 1)
         {
            return currentMax;
         }

         if (n % 2 == 0)
         {
            return GetMaxElement(n / 2, Math.Max(currentMax, n / 2));
         }

         return GetMaxElement(3 * n + 1, Math.Max(currentMax, 3 * n + 1));
      }
   }
}