﻿// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// (на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите количество элементов массива: ");
int countElem = int.Parse(Console.ReadLine());
int [] array = new int[countElem];
     
Random myRandom = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);
    Console.Write("{0}, ", array[i]);
}