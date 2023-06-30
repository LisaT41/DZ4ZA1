// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

 bool ValidPower(int b)
 {
     if (b < 0)
     {
         System.Console.WriteLine("ОШИБКА!!! Число B не должно быть < 0");
         return false;
     }
     return true;
 }

 int FindPower(int a, int b)
 {
     int power = 1;
     for (int i = 0; i < b; i++)
     {
         power *= a;
     }
     return power;
 }
 System.Console.WriteLine("Input number A -> ");
 int a = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Input number B -> ");
 int b = Convert.ToInt32(Console.ReadLine());
 if (ValidPower(b))
 {
     System.Console.WriteLine($"{a} in power {b} is -> {FindPower(a, b)}");
 }
