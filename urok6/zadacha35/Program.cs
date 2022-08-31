﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int minRange = 10;
int maxRange = 99;
int[] array = GenerateRandomIntArray();
ShowArray(array);
Console.Write($"Количество элементов в массиве в диапазоне от {minRange} до {maxRange} получается - {SearchAllNubersInRange(array, minRange, maxRange)}");

int[] GenerateRandomIntArray(int numberArryaElements = 123, int minNumber = 10, int maxNumber = 500)
{
    int[] array = new int[numberArryaElements];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minNumber, maxNumber);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив из 123 случайных чисел:");
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int SearchAllNubersInRange(int[] array, int minRangeNumber, int maxRangeNumber)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > minRangeNumber && item < maxRangeNumber)
        {
            count ++;
        }
    }
    return count;
}
