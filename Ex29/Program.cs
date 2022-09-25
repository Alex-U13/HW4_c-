// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int[] Array = new int[8];

for (int i =0; i<8; i++)                         // при вводе значений самим пользователем
{
    Console.Write("Введите число: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Массив ({Array[0]}, {Array[1]}, {Array[2]}, {Array[3]}, {Array[4]}, {Array[5]}, {Array[6]}, {Array[7]})");



// int i = 0;                                          // заполнение случайными числами
// while (i<8)
// {
// Array[i] = new Random().Next(0,100);
// i++;
// }
// Console.Write($"Массив ({Array[0]}, {Array[1]}, {Array[2]}, {Array[3]}, {Array[4]}, {Array[5]}, {Array[6]}, {Array[7]})");

