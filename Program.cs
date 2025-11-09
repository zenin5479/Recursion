using System;

// Рекурсия

namespace Recursion
{
   internal class Program
   {
      static void Main()
      {
         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.Title = "Рекурсия";
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("Задача Коллаца");
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write("Введите число для проверки >  ");
         Console.Write("Введите начальное число: ");
         if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
         {
            Console.WriteLine("\nПоследовательность Коллатца:");
            PrintSequence(n);

            Console.WriteLine($"\nДлина последовательности: {GetSequenceLength(n)}");
            Console.WriteLine($"Максимальный элемент: {GetMaxElement(n)}");
         }
         else
         {
            Console.WriteLine("Ошибка: введите положительное целое число.");
         }




         uint number = Convert.ToUInt32(Console.ReadLine());
         // Проверяем число
         CollatzRec(number);
         // Восстановление исходного цвета консоли
         Console.ResetColor();
         Console.WriteLine("Восстановлены исходные цвета консоли");

         Console.ReadKey();
      }

      private static void CollatzRec(uint number, int len = 0)
      {
         Console.WriteLine("Шаг " + len + " > " + number);
         if (number <= 1)
         {
            // Ввыводим длину цикла
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Длина цикла для числа " + number + " = " + len);
            return;
         }

         if (number % 2 != 0)
         {
            CollatzRec(number * 3 + 1, ++len);
         }
         else
         {
            CollatzRec(number / 2, ++len);
         }
      }
   }
}