﻿// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (10, 100);
        Console.Write (array[i,j] +"\t  ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите строку элемента: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите столбец элемента: ");
int column = Convert.ToInt32 (Console.ReadLine());
if (row > m && column > n) 
{
    Console.WriteLine ("Такого элемента нет в массиве");
    
}
else
{
    Console.WriteLine ("Элемент массива существует: "+ array[row,column]);
}