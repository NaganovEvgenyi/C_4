/*
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 Console.WriteLine("введите число A");
 int a = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("введите число B");
 int b = Convert.ToInt32(Console.ReadLine());
 int step = a;
 Console.WriteLine($" число {a} в степени {b} = {GetSum(b)}");
 int GetSum(int number)
 {



     for (int i = 1; i < b; i++)
     {
         step = step * a;
     }
     return step;
 }
 */

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


 Console.WriteLine("Введите число:");
 int a = int.Parse(Console.ReadLine()!);
 Console.WriteLine($"Сумма цифр  = {GetSum(a)}");

 int GetSum(int limit)
 {
     int sum = 0;
     int dig = 0;
     while (a > 0)
     {
         dig = a % 10;
         sum = sum + dig;
         a = a / 10;

     }
     return sum;
 }

