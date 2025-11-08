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
         string pop = "У попа была собака, он её любил.\n\r";
         pop += "Она съела кусок мяса - он её убил.\n\r";
         pop += "В землю закопал,\n\r";
         pop += "Надпись написал:\n\r";
         Print(pop, 3);
         Console.ForegroundColor = ConsoleColor.Green;
         PrintWhile(pop, 3);
         Console.ForegroundColor = ConsoleColor.Blue;
         PrintRec(pop, 3);
         Console.ForegroundColor = ConsoleColor.Red;

         Console.ForegroundColor = ConsoleColor.Yellow;
         Console.WriteLine("Задача Коллаца");
         Console.Write("Введите число для проверки >  ");
         var number = Convert.ToUInt32(Console.ReadLine());
         // Проверяем число
         CollatzRec(number);
         // Вычисляем длину Улама
         int len = UlamLength(number);
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("Длина цикла для числа " + number + " = " + len);
         Console.WriteLine();
         Console.ForegroundColor = ConsoleColor.Yellow;
         
         Console.ReadKey();
      }

      private static void CollatzRec(uint number, int len = 0)
      {
         Console.WriteLine("Шаг " + len + " > " + number);
         if (number <= 1)
         {
            // Ввыводим длину цикла в текстовое окно:
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("Длина цикла для числа " + number + " = " + len);
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

      private static int UlamLength(uint number)
      {
         if (number <= 1)
         {
            return 0;
         }

         if (number % 2 != 0)
         {
            return 1 + UlamLength(number * 3 + 1);
         }
         else
         {
            return 1 + UlamLength(number / 2);
         }
      }

      public static void Print(string str, int n)
      {
         for (int i = 0; i < n; ++i)
         {
            Console.WriteLine(str);
         }
      }

      static void PrintWhile(string str, int n)
      {
         if (n < 1)
         {
            return;
         }

         while (n-- != 0)
         {
            Console.WriteLine(str);
         }
      }

      public static void PrintRec(string str, int n)
      {
         Console.WriteLine("n = " + n);
         if (n < 1)
         {
            return;
         }

         Console.WriteLine(str);
         PrintRec(str, --n);
      }
   }
}