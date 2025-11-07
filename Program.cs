using System;

namespace Recursion
{
   internal class Program
   {
      static void Main(string[] args)
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


         Console.ReadKey();
      }

      public static void Print(string str, int n)
      {
         for (int i = 0; i < n; ++i)
            Console.WriteLine(str);
      }

      static void PrintWhile(string str, int n)
      {
         if (n < 1) return;
         while (n-- != 0)
         {
            Console.WriteLine(str);
         }
      }

      public static void PrintRec(string str, int n)
      {
         Console.WriteLine("n = " + n);
         if (n < 1) return;
         Console.WriteLine(str);
         PrintRec(str, --n);
      }
   }
}
