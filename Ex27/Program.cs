// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num;
int count = 0;
while (a != 0)
{
    a = a / 10;
    count++;
}
// Console.WriteLine(count); //  количество цифр в числе

double[] Array = new double[count];
double b = Convert.ToDouble(count);
double Summ = 0;
for (int i = 0; i<count; i++)
{
    Array[i] = Math.Round((num / Math.Pow(10,(b-1))),0);
    // Console.Write($"{Array[i]} "); // проверка значений массива, на этом этапе возникают иногда ошибки. Например, если ввести 452, первое значение почему-то - 5.
    num = Convert.ToInt32(Math.Round((num % Math.Pow(10,(b-1))),0));
    // Console.Write($"{num} - остаток от деления. ");   // доп.проверка корректности остатка от деления
    b = b-1;
    Summ = Summ + Array[i];
}

Console.WriteLine($"Результат суммирования {Summ}");



