// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число, которое необходимо возвести в степень: ");
double N = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень числа: ");
double S = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(Math.Pow(N,S));  // - первый вариант, без цикла

// double result = N;   // - второй вариант с циклом while
// double i = 1;
// while (i<=S)
// {
//     result = Math.Pow(N,i);
//     i++;
// }
// Console.WriteLine(result);

double result = N;          // - третий вариант, с использованием цикла for
for (double i =1; i<=S; i++)
{
    result = Math.Pow(N,i);
}

Console.WriteLine(result);